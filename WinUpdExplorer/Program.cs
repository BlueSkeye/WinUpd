using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WinUpdExplorer
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            // bool allConjectureStand = WsusScanParallelContentConjecture();
            return 0;
        }

        private static bool WsusScanParallelContentConjecture()
        {
            DirectoryInfo baseDirectory = new DirectoryInfo(
                Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "Temp", "WinUpdate20181212", "WSUSSCAN"));
            DirectoryInfo packageDirectory = new DirectoryInfo(
                Path.Combine(baseDirectory.FullName, "PACKAGE"));
            DirectoryInfo wsusscanDirectory = new DirectoryInfo(
                Path.Combine(baseDirectory.FullName, "PACKAGE"));
            if (!packageDirectory.FilesAreSubsetOf(wsusscanDirectory)) {
                return false;
            }
            if (!wsusscanDirectory.FilesAreSubsetOf(packageDirectory)) {
                return false;
            }
            return true;
        }

        private static bool FilesAreSubsetOf(this DirectoryInfo subset, DirectoryInfo superset)
        {
            string subsetFullName = subset.FullName;
            int subsetFullNameLength = subsetFullName.Length;
            string supersetFullName = superset.FullName;
            Stack<DirectoryInfo> pendingSubDirectory = new Stack<DirectoryInfo>();
            pendingSubDirectory.Push(subset);
            byte[] scannedContent = new byte[16 * 1024];
            byte[] expectedContent = new byte[16 * 1024];
            while (0 < pendingSubDirectory.Count) {
                DirectoryInfo candidate = pendingSubDirectory.Pop();
                string candidateFullName = candidate.FullName;
                string suffix = (subsetFullNameLength == candidateFullName.Length)
                    ? string.Empty
                    : candidateFullName.Substring(subsetFullNameLength);
                DirectoryInfo scannedDirectory = new DirectoryInfo(subsetFullName + suffix);
                int scannedDirectoryNameLength = scannedDirectory.FullName.Length;
                foreach (DirectoryInfo pending in scannedDirectory.GetDirectories()) {
                    pendingSubDirectory.Push(pending);
                }
                foreach(FileInfo scannedFile in scannedDirectory.GetFiles()) {
                    string scannedFileFullName = scannedFile.FullName;
                    string relativeFileName = scannedFileFullName.Substring(subsetFullNameLength);
                    string expectedFileName = supersetFullName + relativeFileName;
                    FileInfo expectedFile = new FileInfo(expectedFileName);
                    if (!expectedFile.Exists) {
                        return false;
                    }
                    if (expectedFile.Length != scannedFile.Length) {
                        return false;
                    }
                    using (FileStream input = scannedFile.OpenRead()) {
                        input.Read(scannedContent, 0, scannedContent.Length);
                    }
                    using (FileStream input = expectedFile.OpenRead()) {
                        input.Read(expectedContent, 0, expectedContent.Length);
                    }
                    if (!BuffersMatch(scannedContent, expectedContent)) {
                        return false;
                    }
                    continue;
                }
            }
            return true;
        }

        private static bool BuffersMatch(byte[] x, byte[] y)
        {
            if (x.Length != y.Length) {
                return false;
            }
            int length = x.Length;
            for(int index = 0; index < length; index++) {
                if (x[index] != y[index]) {
                    return false;
                }
            }
            return true;
        }
    }
}
