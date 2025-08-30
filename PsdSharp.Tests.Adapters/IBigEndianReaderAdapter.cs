namespace PsdSharp.Tests.Adapters
{
    public interface IBigEndianReaderAdapter
    {
        short ReadInt16();
        int ReadInt32();
        long ReadInt64();
        
        ushort ReadUInt16();
        uint ReadUInt32();
        ulong ReadUInt64();
        
        string ReadPascalString();
        string ReadPascalString(short startPosition, int padMultiple);
        string ReadUnicodeString();
        
        void ReadPadding(long startPosition, int padMultiple);
        int GetPadding(int length, int padMultiple);
    }
}