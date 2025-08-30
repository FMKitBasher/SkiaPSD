using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class ImageDecoderFactory : Adapter, IImageDecoderFactoryAdapter
    {
        public IImageDecoderAdapter Create() => new ImageDecoderAdapter();
    }
}
