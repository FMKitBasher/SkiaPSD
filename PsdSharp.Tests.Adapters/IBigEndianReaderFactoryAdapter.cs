using System.IO;

namespace PsdSharp.Tests.Adapters
{
    public interface IBigEndianReaderFactoryAdapter
    {
        IBigEndianReaderAdapter Create(Stream stream);
    }
}