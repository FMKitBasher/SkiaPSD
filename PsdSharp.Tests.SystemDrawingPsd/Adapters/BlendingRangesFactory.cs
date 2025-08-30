using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class BlendingRangesFactory : Adapter, IBlendingRangesFactoryAdapter
    {
        public IBlendingRangesAdapter Create(ILayerAdapter layer)
            => new BlendingRangesAdapter(new Layer.BlendingRanges(Unwrap<LayerAdapter>(layer, nameof(layer)).Subject));

        public IBlendingRangesAdapter Create(IBigEndianReaderAdapter bigEndianReader, ILayerAdapter layer)
            => new BlendingRangesAdapter(new Layer.BlendingRanges(
                Unwrap<BigEndianReaderAdapter>(bigEndianReader, nameof(bigEndianReader)).Subject,
                Unwrap<LayerAdapter>(layer, nameof(layer)).Subject));
    }
}
