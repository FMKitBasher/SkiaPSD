using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class ResolutionInfoFactory : Adapter, IResolutionInfoFactoryAdapter
    {
        public IResolutionInfoAdapter Create() => new ResolutionInfoAdapter(new ResolutionInfo());

        public IResolutionInfoAdapter Create(IImageResourceAdapter imageResource)
            => new ResolutionInfoAdapter(new ResolutionInfo(Unwrap<ImageResourceAdapter>(imageResource, nameof(imageResource)).Subject));
    }
}
