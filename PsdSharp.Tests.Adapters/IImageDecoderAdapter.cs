namespace PsdSharp.Tests.Adapters
{
    public interface IImageDecoderAdapter
    {
        byte[] DecodeImage(IPsdFileAdapter psdFile);
        byte[] DecodeImage(ILayerAdapter layer);
        byte[] DecodeImage(ILayerMaskAdapter layerMask);
    }
}