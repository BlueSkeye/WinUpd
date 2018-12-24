using System;
using System.IO;
using System.Text;

namespace WinUpdExplorer
{
    internal class XmlFragmentSerializationWrapper : Stream
    {
        internal XmlFragmentSerializationWrapper(FileInfo content, string rootNodeName,
            params Tuple<string, string>[] namespaces)
        {
            _contentStream = File.Open(content.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StringBuilder headerBuilder = new StringBuilder();
            headerBuilder.Append(HeaderVersionAndEncoding);
            headerBuilder.AppendFormat("<{0}", rootNodeName);
            if ((null != namespaces) && (0 < namespaces.Length)) {
                foreach(Tuple<string, string> namespaceAndPrefix in namespaces) {
                    headerBuilder.AppendFormat(" xmlns:{0}=\"{1}\"", namespaceAndPrefix.Item1, namespaceAndPrefix.Item2);
                }
            }
            headerBuilder.Append(">");
            _header = Encoding.UTF8.GetBytes(headerBuilder.ToString());
            _footer = Encoding.UTF8.GetBytes(string.Format(FooterPattern, rootNodeName));
            _offset = -(_header.Length);
        }

        public override bool CanRead => true;

        public override bool CanSeek => false;

        public override bool CanWrite => false;

        public override long Length => throw new NotSupportedException();

        public override long Position
        {
            get => throw new NotSupportedException();
            set => throw new NotSupportedException(); }

        public new void Dispose()
        {
            _contentStream.Close();
            _contentStream = null;
        }

        internal void DumpContent()
        {
            byte[] buffer = new byte[_contentStream.Length + 1024];
            this.Reset();
            int readCount = this.Read(buffer, 0, buffer.Length);
            string content = Encoding.UTF8.GetString(buffer, 0, readCount);
            Console.WriteLine("============================");
            Console.WriteLine(content);
            Console.WriteLine("============================");
        }

        public override void Flush()
        {
            throw new NotSupportedException();
        }

        public override int Read(byte[] buffer, int bufferOffset, int count)
        {
            if (0 > bufferOffset) {
                throw new ArgumentOutOfRangeException();
            }
            if (buffer.Length < (bufferOffset + count)) {
                throw new ArgumentException();
            }
            if (0 == count) {
                return 0;
            }
            int result = 0;
            int required = count;
            while (0 < required) {
                // Handle header.
                if (0 > _offset) {
                    int fromHeaderCount = Math.Min(required, -(_offset));
                    Buffer.BlockCopy(_header, _header.Length + _offset, buffer, bufferOffset, fromHeaderCount);
                    required -= fromHeaderCount;
                    result += fromHeaderCount;
                    bufferOffset += fromHeaderCount;
                    _offset += fromHeaderCount;
                    if (0 >= required) {
                        break;
                    }
                }
                // Read from fragment.
                if (0 == _offset) {
                    int readCount = _contentStream.Read(buffer, bufferOffset, required);
                    required -= readCount;
                    result += readCount;
                    bufferOffset += readCount;
                    if (0 >= required) {
                        break;
                    }
                }
                int fromFooterCount = Math.Min(required, _footer.Length - _offset);
                Buffer.BlockCopy(_footer, _offset, buffer, bufferOffset, fromFooterCount);
                required -= fromFooterCount;
                result += fromFooterCount;
                bufferOffset += fromFooterCount;
                _offset += fromFooterCount;
                if (0 >= required) {
                    break;
                }
                if (_footer.Length <= _offset) {
                    break;
                }
            }
            return result;
        }

        internal void Reset()
        {
            _offset = -(_header.Length);
            _contentStream.Position = 0;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotSupportedException();
        }

        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException();
        }

        private const string FooterPattern = "</{0}>";
        private const string HeaderVersionAndEncoding = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
        private const string HeaderPattern = "<?xml version=\"1.0\" encoding=\"utf-8\"?><{0}>";
        private FileStream _contentStream;
        private byte[] _footer;
        private byte[] _header;
        private int _offset;
    }
}
