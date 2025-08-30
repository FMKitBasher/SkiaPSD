using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class AdjustmentLayerInfoAdapter(Layer.AdjusmentLayerInfo subject) : Adapter<Layer.AdjusmentLayerInfo>(subject), IAdjustmentLayerInfoAdapter
    {
        public string Key => Subject.Key;
        public byte[] Data => Subject.Data;
        public IBigEndianReaderAdapter DataReader => new BigEndianReaderAdapter(Subject.DataReader);
    }
}