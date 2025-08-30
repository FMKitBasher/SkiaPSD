using System.Drawing.PSD;
using System.Drawing.Imaging;
using System.IO;
using PsdSharp.Tests.Adapters;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters
{
    public class ImageDecoderAdapter : Adapter, IImageDecoderAdapter
    {
        public byte[] DecodeImage(IPsdFileAdapter psdFile)
        {
            var file = Unwrap<PsdFileAdapter>(psdFile, nameof(psdFile)).Subject;
            using var bmp = ImageDecoder.DecodeImage(file);
            return BitmapToBytes(bmp);
        }

        public byte[] DecodeImage(ILayerAdapter layer)
        {
            var l = Unwrap<LayerAdapter>(layer, nameof(layer)).Subject;
            using var bmp = ImageDecoder.DecodeImage(l);
            return BitmapToBytes(bmp);
        }

        public byte[] DecodeImage(ILayerMaskAdapter layerMask)
        {
            var m = Unwrap<LayerMaskAdapter>(layerMask, nameof(layerMask)).Subject;
            using var bmp = ImageDecoder.DecodeImage(m);
            return BitmapToBytes(bmp);
        }

        private static byte[] BitmapToBytes(System.Drawing.Bitmap? bmp)
        {
            if (bmp == null) return [];
            using var ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
