using System.IO;
using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class BigEndianReaderFactory : Adapter, IBigEndianReaderFactoryAdapter
    {
        public IBigEndianReaderAdapter Create(Stream stream)
            => new BigEndianReaderAdapter(new BinaryReverseReader(stream));
    }
}
