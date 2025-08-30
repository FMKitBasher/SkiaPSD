using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class BigEndianReaderAdapter(BinaryReverseReader subject) : IBigEndianReaderAdapter
    {
        public readonly BinaryReverseReader Subject = subject;

        public short ReadInt16() => Subject.ReadInt16();
        public int ReadInt32() => Subject.ReadInt32();
        public long ReadInt64() => Subject.ReadInt64();
        public ushort ReadUInt16() => Subject.ReadUInt16();
        public uint ReadUInt32() => Subject.ReadUInt32();
        public ulong ReadUInt64() => Subject.ReadUInt64();
        public string ReadPascalString() => Subject.ReadPascalString();
        public string ReadPascalString(short startPosition, int padMultiple) => Subject.ReadPascalString(startPosition, padMultiple);
        public string ReadUnicodeString() => Subject.ReadUnicodeString();

        public void ReadPadding(long startPosition, int padMultiple) => Subject.ReadPadding(startPosition, padMultiple);
        public int GetPadding(int length, int padMultiple) => Subject.GetPadding(length, padMultiple);
    }
}