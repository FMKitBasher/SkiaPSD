using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class ImageResourceAdapter(ImageResource subject) : Adapter<ImageResource>(subject), IImageResourceAdapter
    {
        public short Id => Subject.ID;
        public string Name => Subject.Name;
        public byte[] Data => Subject.Data;
        public string OSType => Subject.OSType;
        public IBigEndianReaderAdapter DataReader => new BigEndianReaderAdapter(Subject.DataReader);
        public new string ToString() => Subject.ToString();
    }
}
