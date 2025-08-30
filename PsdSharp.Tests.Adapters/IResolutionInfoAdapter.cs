using PsdSharp.Types;

namespace PsdSharp.Tests.Adapters
{
    public interface IResolutionInfoAdapter
    {
        short HRes { get; }
        short VRes { get; }
        
        ResolutionUnit HResUnit { get; }
        ResolutionUnit VResUnit { get; }
        
        Unit WidthUnit { get; }
        Unit HeightUnit { get; }

        string ToString();
    }
}