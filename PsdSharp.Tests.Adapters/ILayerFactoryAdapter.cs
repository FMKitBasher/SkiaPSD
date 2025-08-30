namespace PsdSharp.Tests.Adapters
{
    public interface ILayerFactoryAdapter
    {
       ILayerAdapter Create(IPsdFileAdapter psdFile);
       ILayerAdapter Create(IBigEndianReaderAdapter bigEndianReader, IPsdFileAdapter psdFile);
    }
}