using System.IO;
using System.Reflection;

namespace PsdSharp.Tests.Assets
{
    public static class ResourceHelper
    {
        public static Stream GetAsset(string assetName)
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream($"PsdSharp.Tests.Assets.{assetName}")!;
        }
    }
}