using System.Drawing.PSD;
using PsdSharp.Tests.Adapters;
using PsdSharp.Types;

namespace PsdSharp.Tests.SystemDrawingPsd.Adapters;

public class ResolutionInfoAdapter(ResolutionInfo subject) : Adapter<ResolutionInfo>(subject), IResolutionInfoAdapter
{
    public short HRes => Subject.HRes;
    public short VRes => Subject.VRes;
    public ResolutionUnit HResUnit => Subject.HResUnit;
    public ResolutionUnit VResUnit => Subject.VResUnit;
    public Unit HeightUnit => Subject.HeightUnit;
    public Unit WidthUnit => Subject.WidthUnit;
    public new string ToString() => Subject.ToString();
}