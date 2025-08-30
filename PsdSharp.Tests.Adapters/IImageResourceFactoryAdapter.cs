namespace PsdSharp.Tests.Adapters
{
    public interface IImageResourceFactoryAdapter
    {
        IImageResourceAdapter Create();
        IImageResourceAdapter Create(short id);
        IImageResourceAdapter Create(IImageResourceAdapter imageResource);
        IImageResourceAdapter Create(IBigEndianReaderAdapter bigEndianReader);
        
    }
}