namespace PsdSharp.Tests.Adapters
{
    public interface IAdjustmentLayerInfoFactoryAdapter
    {
        IAdjustmentLayerInfoAdapter Create(string key, ILayerAdapter layer);
        IAdjustmentLayerInfoAdapter Create(IBigEndianReaderAdapter bigEndianReader, ILayerAdapter layer);
    }
}