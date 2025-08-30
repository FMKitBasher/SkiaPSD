using PsdSharp.Types;

namespace PsdSharp.Tests.Adapters
{
    public interface ILayerChannelAdapter
    {
        ILayerAdapter Layer { get; }
        short Id { get; }
        int Length { get; }
        byte[] Data { get; }
        byte[] ImageData { get; }
        ImageCompression ImageCompression { get; }
        IBigEndianReaderAdapter DataReader { get; }
    }
}