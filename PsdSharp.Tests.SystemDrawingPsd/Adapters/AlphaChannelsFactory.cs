using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class AlphaChannelsFactory : Adapter, IAlphaChannelsFactoryAdapter
    {
        public IAlphaChannelsAdapter Create() => new AlphaChannelsAdapter(new AlphaChannels());
        
        public IAlphaChannelsAdapter Create(IImageResourceAdapter imageResource) => 
            new AlphaChannelsAdapter(
                new AlphaChannels(Unwrap<ImageResourceAdapter>(imageResource, nameof(imageResource)).Subject)
            );
    }
}
