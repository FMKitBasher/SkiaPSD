namespace PsdSharp.Tests.Adapters;

public abstract class AdapterCollection
{
    public abstract IAdjustmentLayerInfoFactoryAdapter AdjustmentLayerInfoFactory { get; }
    public abstract IAlphaChannelsFactoryAdapter AlphaChannelsFactory { get; }
    public abstract IBigEndianReaderFactoryAdapter BigEndianReaderFactory { get; }
    public abstract IBlendingRangesFactoryAdapter BlendingRangesFactory { get; }
    public abstract IImageDecoderFactoryAdapter ImageDecoderFactory { get; }
    public abstract IImageResourceFactoryAdapter ImageResourceFactory { get; }
    public abstract IPsdFileLoaderAdapter PsdFileLoader { get; }
    public abstract IResolutionInfoFactoryAdapter ResolutionInfoFactory { get; }
}