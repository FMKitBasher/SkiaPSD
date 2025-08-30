using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;
using PsdSharp.Types;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class LayerChannelAdapter(Layer.Channel subject) : Adapter<Layer.Channel>(subject), ILayerChannelAdapter
    {
        public ILayerAdapter Layer => new LayerAdapter(Subject.Layer);
        public short Id => Subject.ID;
        public int Length => Subject.Length;
        public byte[] Data => Subject.Data;
        public byte[] ImageData => Subject.ImageData;
        public ImageCompression ImageCompression => Subject.ImageCompression;
        public IBigEndianReaderAdapter DataReader => new BigEndianReaderAdapter(Subject.DataReader);
    }
}
