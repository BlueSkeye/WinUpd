using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WinUpdExplorer
{
    internal class XmlFragmentSerializationWrapper : Stream
    {
        internal XmlFragmentSerializationWrapper(FileInfo content, string rootNodeName)
        {
            _contentStream = File.Open(content.FullName, FileMode.Open, FileAccess.Read);
            _header = Encoding.UTF8.GetBytes(string.Format(HeaderPattern, rootNodeName));
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

        public override void Flush()
        {
            throw new NotSupportedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (0 > offset) {
                throw new ArgumentOutOfRangeException();
            }
            if (buffer.Length < (offset + count)) {
                throw new ArgumentException();
            }
            if (0 == count) {
                return 0;
            }
            int result = 0;
            int required = count;
            while (0 < required) {
                if (0 > offset) {
                    int fromHeaderCount = Math.Min(required, -(offset));
                    Buffer.BlockCopy(_header, _header.Length - offset, buffer, offset, fromHeaderCount);
                    required -= fromHeaderCount;
                    result += fromHeaderCount;
                    if (0 >= required) {
                        break;
                    }
                    offset += fromHeaderCount;
                }
                if (0 == offset) {
                    int readCount = _contentStream.Read(buffer, offset, required);
                    required -= readCount;
                    result += readCount;
                    offset += readCount;
                    if (0 >= required) {
                        break;
                    }
                    // TODO
                    throw new NotImplementedException();

                    int fromContent = Math.Min(required, -(offset));
                    Buffer.BlockCopy(_header, _header.Length - offset, buffer, offset, fromContent);
                    required -= fromContent;
                    result += fromContent;
                    if (0 >= required) {
                        break;
                    }
                    offset += fromContent;
                }
            }
            return result;
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

        private const string FooterPattern = "<{0}/>";
        private const string HeaderPattern = "<?xml version=\"1.0\" encoding=\"utf-8\"?><{0}>";
        private FileStream _contentStream;
        private byte[] _footer;
        private byte[] _header;
        private int _offset;
    }
}
