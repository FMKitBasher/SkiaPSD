using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class AdjustmentLayerInfoFactory : Adapter, IAdjustmentLayerInfoFactoryAdapter
    {
        public IAdjustmentLayerInfoAdapter Create(string key, ILayerAdapter layer)
        =>  new AdjustmentLayerInfoAdapter(new Layer.AdjusmentLayerInfo(key,
                Unwrap<LayerAdapter>(layer, nameof(layer)).Subject));

        public IAdjustmentLayerInfoAdapter Create(IBigEndianReaderAdapter bigEndianReader, ILayerAdapter layer)
        => new AdjustmentLayerInfoAdapter(
            new Layer.AdjusmentLayerInfo(
                Unwrap<BigEndianReaderAdapter>(bigEndianReader, nameof(bigEndianReader)).Subject,
                Unwrap<LayerAdapter>(layer, nameof(layer)).Subject
            )
        );
    }
}