using System.Drawing.PSD;
using System.IO;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class PsdFileLoaderAdapter : Adapter, IPsdFileLoaderAdapter
    {
        public IPsdFileAdapter Load(string filePath)
        {
            var file = new PsdFile().Load(filePath);
            return new PsdFileAdapter(file);
        }

        public IPsdFileAdapter Load(FileInfo fileInfo)
        {
            var file = new PsdFile().Load(fileInfo);
            return new PsdFileAdapter(file);
        }

        public IPsdFileAdapter Load(Stream stream)
        {
            var file = new PsdFile().Load(stream);
            return new PsdFileAdapter(file);
        }
    }
}
