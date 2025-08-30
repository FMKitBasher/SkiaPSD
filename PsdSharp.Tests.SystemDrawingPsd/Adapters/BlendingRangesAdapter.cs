using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class BlendingRangesAdapter(Layer.BlendingRanges subject)
        : Adapter<Layer.BlendingRanges>(subject), IBlendingRangesAdapter
    {
        public ILayerAdapter Layer => new LayerAdapter(Subject.Layer);
        public byte[] Data => Subject.Data;
    }
}
