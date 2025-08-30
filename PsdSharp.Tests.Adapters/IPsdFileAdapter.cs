using System.Collections.Generic;
using PsdSharp.Types;

namespace PsdSharp.Tests.Adapters
{
    public interface IPsdFileAdapter
    {
        byte[] ColorModeData { get; }
        short Version { get; }
        short AmountOfChannels { get; }
        
        ILayerAdapter LayerTree { get; }
        
        int NumRows { get; }
        int NumColumns { get; }
        int ChannelDepth { get; }
        
        ColorMode ColorMode { get; }
        bool AbsoluteAlpha { get; }
        byte[][] ImageData { get; }
        ImageCompression ImageCompression { get; }
        
        IEnumerable<IImageResourceAdapter> ImageResources { get; }
        
        IResolutionInfoAdapter ResolutionInfo { get; }
    }
}