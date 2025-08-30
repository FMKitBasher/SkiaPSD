namespace PsdSharp.Tests.Adapters
{
    public interface IResolutionInfoFactoryAdapter
    {
        IResolutionInfoAdapter Create();
        IResolutionInfoAdapter Create(IImageResourceAdapter imageResource);
    }
}