using System.Collections.Generic;
using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;
using PsdSharp.Types;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters;

public class LayerAdapter(Layer subject) : Adapter<Layer>(subject), ILayerAdapter
{
    public Rectangle Rect => new Rectangle(Subject.Rect.Left, Subject.Rect.Top, Subject.Rect.Width, Subject.Rect.Height);
    public IEnumerable<ILayerChannelAdapter> Channels => Subject.Channels.ConvertAll<ILayerChannelAdapter>(c => new LayerChannelAdapter(c));
    public SortedList<short, ILayerChannelAdapter> SortedChannels
    {
        get
        {
            var list = new SortedList<short, ILayerChannelAdapter>();
            foreach (var kvp in Subject.SortedChannels)
            {
                list.Add(kvp.Key, new LayerChannelAdapter(kvp.Value));
            }
            return list;
        }
    }
    public BlendMode BlendMode => BlendMode.FromKey(Subject.BlendModeKey) ?? BlendMode.Normal;
    public byte Opacity => Subject.Opacity;
    public LayerClipping Clipping => Subject.Clipping ? LayerClipping.NonBase : LayerClipping.Base;
    public bool IsVisible => Subject.Visible;
    public bool ProtectTransparency => Subject.ProtectTrans;
    public string Name => Subject.Name;
    public ILayerAdapter? Parent => Subject.Parent == null ? null : new LayerAdapter(Subject.Parent);
    public IEnumerable<ILayerAdapter> Children
    {
        get
        {
            foreach (var child in Subject.Children)
            {
                yield return new LayerAdapter(child);
            }
        }
    }
    public int Id => Subject.ID;
    public LayerSectionType SectionType => Subject.SectionType;
    public IBlendingRangesAdapter BlendingRangesData => new BlendingRangesAdapter(Subject.BlendingRangesData);
    public ILayerMaskAdapter MaskData => new LayerMaskAdapter(Subject.MaskData);
    public IAdjustmentLayerInfoAdapter AdjustmentInfo => new AdjustmentLayerInfoAdapter(Subject.AdjustmentInfo[0]);
}