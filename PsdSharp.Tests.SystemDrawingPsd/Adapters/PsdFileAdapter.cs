using System.Collections.Generic;
using System.Drawing.PSD;
using System.Linq;
using PsdSharp.Tests.Adapters;
using PsdSharp.Types;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters;

public class PsdFileAdapter(PsdFile subject) : Adapter<PsdFile>(subject), IPsdFileAdapter
{
    public byte[] ColorModeData => Subject.ColorModeData;
    public short Version => Subject.Version;
    public short AmountOfChannels => Subject.Channels;
    public ILayerAdapter LayerTree => new LayerAdapter(Subject.LayerTree);
    public int NumRows => Subject.Rows;
    public int NumColumns => Subject.Columns;
    public int ChannelDepth => Subject.Depth;
    public ColorMode ColorMode => Subject.ColorMode;
    
    public bool AbsoluteAlpha => Subject.AbsoluteAlpha;
    public byte[][] ImageData => Subject.ImageData;
    public ImageCompression ImageCompression => Subject.ImageCompression;

    public IEnumerable<IImageResourceAdapter> ImageResources
    {
        get { return Subject.ImageResources.Select(imageResource => new ImageResourceAdapter(imageResource)); }
    }
    
    public IResolutionInfoAdapter ResolutionInfo => new ResolutionInfoAdapter(Subject.Resolution);
}