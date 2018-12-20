using System;
using System.Collections.Generic;

using Microsoft.Win32;

namespace WinUpdExplorer
{
    /// <summary>Handles update sequencing process. The algorithm accounts for already installed
    /// updates and for dependencies that may occur between updates in the package itself.</summary>
    /// <remarks>TODO : It lloks like updates may share a unique identifier with different revision
    /// number. The current algorithm doesn't distinguish between such two updates.</remarks>
    internal class UpdateDependencyManager
    {
        internal UpdateDependencyManager(Container.Package package)
        {
            _package = package;
            InitializeAvailableUpdates();
        }

        /// <summary>Build the dependencies tree.</summary>
        /// <remarks>TODO : This is buggy. We should rely on RevisionId.</remarks>
        internal void BuildDependencies(bool traceDependencies = false)
        {
            SequencerState state = new SequencerState(traceDependencies);
            Container.Update[] updates = _package.Updates;
            foreach(Container.Update candidate in updates) {
                Guid updateId = candidate.UpdateId;

                if (null == candidate.Prerequisites) {
                    state.ApplyUpdate(updateId, Guid.Empty);
                    continue;
                }

                foreach(object prerequisite in candidate.Prerequisites) {
                    if (prerequisite is Container.UpdateIdReference) {
                        Guid requiredUpdateId = ((Container.UpdateIdReference)prerequisite).Id;
                        state.ConditionalyApplyUpdate(updateId, requiredUpdateId);
                        continue;
                    }
                    if (prerequisite is Container.UpdateIdReferenceCollection) {
                        foreach(Container.UpdateIdReference reference in ((Container.UpdateIdReferenceCollection)prerequisite).UpdateIds) {
                            Guid requiredUpdateId = reference.Id;
                            if (state.ConditionalyApplyUpdate(updateId, requiredUpdateId)) {
                                break;
                            }
                        }
                        continue;
                    }
                    throw new ApplicationException("BUG");
                }
            }
            state.FinalizeState();
            return;
        }

        private void InitializeAvailableUpdates()
        {
            _packageUpdates = new Dictionary<Guid, string>();
            foreach (Container.Update candidate in _package.Updates) {
                Guid updateId = candidate.UpdateId;
                Tuple<Guid, uint> key = new Tuple<Guid, uint>(updateId, candidate.RevisionId);
                try {
                    if (!_packageUpdates.ContainsKey(updateId)) {
                        _packageUpdates.Add(updateId, null);
                    }
                }
                catch (Exception e) {
                    string otherRevisionId = _packageUpdates[updateId];
                    throw;
                }
            }
            return;
        }

        private Container.Package _package;
        private Dictionary<Guid, string> _packageUpdates = new Dictionary<Guid, string>();

        private class SequencerState
        {
            internal SequencerState(bool traceDependencies)
            {
                TraceDependencies = traceDependencies;
                InitializeInstalledUpdatesList();
            }

            internal uint AppliedUpdatesCount { get; private set; }

            internal bool TraceDependencies { get; set; }

            internal void ApplyUpdate(Guid updateId, Guid parent)
            {
                if (TraceDependencies) {
                    if (Guid.Empty == parent) {
                        Console.WriteLine("Update {0} will be unconditionally installed.", updateId);
                    }
                    else {
                        Console.WriteLine("Update {0} will be installed because {1} is installed.", updateId, parent);
                    }
                }
                if (!_alreadyAcceptedUpdates.ContainsKey(updateId)) {
                    _alreadyAcceptedUpdates.Add(updateId, updateId);
                    AppliedUpdatesCount++;
                }
            }

            internal bool ConditionalyApplyUpdate(Guid updateId, Guid parent)
            {
                if (_alreadyAcceptedUpdates.ContainsKey(parent) || _installedUpdates.ContainsKey(parent)) {
                    ApplyUpdate(updateId, parent);
                    return true;
                }
                List<Guid> pendings;
                if (!_pendingDecision.TryGetValue(parent, out pendings)) {
                    pendings = new List<Guid>();
                    _pendingDecision.Add(parent, pendings);
                }
                pendings.Add(updateId);
                if (TraceDependencies) {
                    Console.WriteLine("Update {0} pending upon {1}.", updateId, parent);
                }
                return false;
            }

            private void InitializeInstalledUpdatesList()
            {
                _installedUpdates = new Dictionary<Guid, RegistryView>();
                foreach(RegistryView view in new RegistryView[] { RegistryView.Registry32, RegistryView.Registry64 }) {
                    using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, view)) {
                        using (RegistryKey uninstallKey = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall")) {
                            foreach(string candidate in uninstallKey.GetSubKeyNames()) {
                                Guid updateId;
                                if (!Guid.TryParse(candidate, out updateId)) {
                                    continue;
                                }
                                if (!_installedUpdates.ContainsKey(updateId)) {
                                    _installedUpdates.Add(updateId, view);
                                }
                                else {
                                    throw new ApplicationException("BUG");
                                }
                            }
                        }
                    }
                }
                return;
            }

            internal void FinalizeState()
            {
                List<Guid> pendingPropagation = new List<Guid>();
                foreach(KeyValuePair<Guid, List<Guid>> items in _pendingDecision) {
                    Guid candidateKey = items.Key;
                    if (_alreadyAcceptedUpdates.ContainsKey(candidateKey)) {
                        pendingPropagation.Add(candidateKey);
                    }
                }
                // We run allalong the pendingPropagation list. Additional items may be
                // added to the list in the loop below. Hence it is essential not to
                // factorize the list Count property out of the loop exit test.
                for(int index = 0; pendingPropagation.Count > index; index++) {
                    Guid parentKey = pendingPropagation[index];
                    if (!_alreadyAcceptedUpdates.ContainsKey(parentKey)) {
                        continue;
                    }
                    List<Guid> descendents;
                    if (!_pendingDecision.TryGetValue(parentKey, out descendents)) {
                        // The parentKey has no descendent.
                        continue;
                    }
                    foreach(Guid promoted in descendents) {
                        if (!ConditionalyApplyUpdate(promoted, parentKey)) {
                            throw new ApplicationException("BUG");
                        }
                        pendingPropagation.Add(promoted);
                    }
                }
            }

            private SortedList<Guid, Guid> _alreadyAcceptedUpdates = new SortedList<Guid, Guid>();
            private SortedList<Guid, Guid> _alreadyRejectedUpdates = new SortedList<Guid, Guid>();
            private Dictionary<Guid, RegistryView> _installedUpdates;
            private Dictionary<Guid, List<Guid>> _pendingDecision = new Dictionary<Guid, List<Guid>>();
        }
    }
}
