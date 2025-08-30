namespace PsdSharp.Tests.Adapters
{
    public interface IImageResourceAdapter
    {
        short Id { get; }
        string Name { get; }
        byte[] Data { get; }
        string OSType { get; }
        IBigEndianReaderAdapter DataReader { get; }
        
        string ToString();
    }
}