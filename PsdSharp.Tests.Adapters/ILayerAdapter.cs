using System.Collections.Generic;
using PsdSharp.Types;

namespace PsdSharp.Tests.Adapters
{
    public interface ILayerAdapter
    {
        Rectangle Rect { get; }
        IEnumerable<ILayerChannelAdapter> Channels { get; }
        SortedList<short, ILayerChannelAdapter> SortedChannels { get; }
        BlendMode BlendMode { get; }
        
        /// <summary>
        /// 0 = transparent, 255 = opaque
        /// </summary>
        byte Opacity { get; }
        
        LayerClipping Clipping { get; }
        
        bool IsVisible { get; }
        bool ProtectTransparency { get; }
        
        string Name { get; }
        ILayerAdapter? Parent { get; }
        IEnumerable<ILayerAdapter> Children { get; }
        
        int Id { get; }
        LayerSectionType SectionType { get; }
        IBlendingRangesAdapter BlendingRangesData { get; }
        ILayerMaskAdapter MaskData { get; }
        IAdjustmentLayerInfoAdapter AdjustmentInfo { get; }

        string ToString();
    }
}