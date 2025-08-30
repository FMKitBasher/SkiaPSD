using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class LayerFactoryAdapter : Adapter, ILayerFactoryAdapter
    {
        public ILayerAdapter Create(IPsdFileAdapter psdFile)
        {
            var file = Unwrap<PsdFileAdapter>(psdFile, nameof(psdFile)).Subject;
            return new LayerAdapter(new Layer(file));
        }

        public ILayerAdapter Create(IBigEndianReaderAdapter bigEndianReader, IPsdFileAdapter psdFile)
        {
            var reader = Unwrap<BigEndianReaderAdapter>(bigEndianReader, nameof(bigEndianReader)).Subject;
            var file = Unwrap<PsdFileAdapter>(psdFile, nameof(psdFile)).Subject;
            return new LayerAdapter(new Layer(reader, file));
        }
    }
}
