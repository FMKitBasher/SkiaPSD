using System.IO;

namespace PsdSharp.Tests.Adapters
{
    public interface IPsdFileLoaderAdapter
    {
        IPsdFileAdapter Load(string filePath);
        IPsdFileAdapter Load(FileInfo file);
        IPsdFileAdapter Load(Stream stream);
    }
}