using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class ImageResourceFactory : Adapter, IImageResourceFactoryAdapter
    {
        public IImageResourceAdapter Create()
            => new ImageResourceAdapter(new ImageResource());

        public IImageResourceAdapter Create(short id)
            => new ImageResourceAdapter(new ImageResource(id));

        public IImageResourceAdapter Create(IImageResourceAdapter imageResource)
            => new ImageResourceAdapter(new ImageResource(Unwrap<ImageResourceAdapter>(imageResource, nameof(imageResource)).Subject));

        public IImageResourceAdapter Create(IBigEndianReaderAdapter bigEndianReader)
            => new ImageResourceAdapter(new ImageResource(Unwrap<BigEndianReaderAdapter>(bigEndianReader, nameof(bigEndianReader)).Subject));
    }
}
