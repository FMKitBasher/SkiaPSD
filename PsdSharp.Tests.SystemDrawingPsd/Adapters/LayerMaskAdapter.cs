using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;
using PsdSharp.Types;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class LayerMaskAdapter(Layer.Mask subject) : Adapter<Layer.Mask>(subject), ILayerMaskAdapter
    {
        public ILayerAdapter Layer => new LayerAdapter(Subject.Layer);
        public Rectangle Rect => new(Subject.Rect.Left, Subject.Rect.Top, Subject.Rect.Width, Subject.Rect.Height);
        public byte DefaultColor => Subject.DefaultColor;
        public bool PositionIsRelative => Subject.PositionIsRelative;
        public bool IsDisabled => Subject.Disabled;
        public bool InvertOnBlend => Subject.InvertOnBlendBit;
        public byte[] ImageData
        {
            get => Subject.ImageData;
            set => Subject.ImageData = value;
        }
    }
}
