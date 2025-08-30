namespace PsdSharp.Tests.Adapters
{
    public interface IAlphaChannelsFactoryAdapter
    {
        IAlphaChannelsAdapter Create();
        IAlphaChannelsAdapter Create(IImageResourceAdapter imageResource);
    }
}