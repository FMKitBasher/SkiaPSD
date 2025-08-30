namespace PsdSharp.Tests.Adapters
{
    public interface IAdjustmentLayerInfoAdapter
    {
        string Key { get; }
        byte[] Data { get; }
        IBigEndianReaderAdapter DataReader { get; }
    }
}