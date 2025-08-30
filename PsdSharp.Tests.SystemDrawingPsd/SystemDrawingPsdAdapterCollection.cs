using PsdSharp.Tests.Adapters;
using PsdSharp.Tests.SystemDrawingPsd.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd;

public class SystemDrawingPsdAdapterCollection : AdapterCollection
{
    public override IAdjustmentLayerInfoFactoryAdapter AdjustmentLayerInfoFactory => new AdjustmentLayerInfoFactory();
    public override IAlphaChannelsFactoryAdapter AlphaChannelsFactory => new  AlphaChannelsFactory();
    public override IBigEndianReaderFactoryAdapter BigEndianReaderFactory => new BigEndianReaderFactory();
    public override IBlendingRangesFactoryAdapter BlendingRangesFactory => new BlendingRangesFactory();
    public override IImageDecoderFactoryAdapter ImageDecoderFactory => new ImageDecoderFactory();
    public override IImageResourceFactoryAdapter ImageResourceFactory => new ImageResourceFactory();
    public override IPsdFileLoaderAdapter PsdFileLoader => new PsdFileLoaderAdapter();
    public override IResolutionInfoFactoryAdapter ResolutionInfoFactory => new ResolutionInfoFactory();
}