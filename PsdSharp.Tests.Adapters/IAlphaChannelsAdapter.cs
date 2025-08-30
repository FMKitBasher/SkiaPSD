using System.Collections.Generic;

namespace PsdSharp.Tests.Adapters
{
    public interface IAlphaChannelsAdapter : IImageResourceAdapter
    {
        IEnumerable<string> ChannelNames { get; }
    }
}