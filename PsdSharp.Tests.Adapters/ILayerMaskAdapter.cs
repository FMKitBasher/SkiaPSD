using PsdSharp.Types;

namespace PsdSharp.Tests.Adapters
{
    public interface ILayerMaskAdapter
    {
        ILayerAdapter Layer { get; }
        Rectangle Rect { get; }
        byte DefaultColor { get; }
        
        bool PositionIsRelative { get; }
        bool IsDisabled { get; }
        bool InvertOnBlend { get; }
        
        byte[] ImageData { get; set; }
    }
}