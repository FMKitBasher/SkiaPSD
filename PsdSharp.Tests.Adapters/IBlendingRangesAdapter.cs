namespace PsdSharp.Tests.Adapters
{
    public interface IBlendingRangesAdapter
    {
        ILayerAdapter Layer { get; }
        byte[] Data { get; }
    }
}