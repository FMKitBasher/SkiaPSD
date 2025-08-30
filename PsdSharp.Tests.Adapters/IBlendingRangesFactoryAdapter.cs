namespace PsdSharp.Tests.Adapters
{
    public interface IBlendingRangesFactoryAdapter
    {
        IBlendingRangesAdapter Create(ILayerAdapter layer);
        IBlendingRangesAdapter Create(IBigEndianReaderAdapter bigEndianReader, ILayerAdapter layer);
    }
}