using System.Collections.Generic;

namespace PsdSharp.Types;

public class BlendMode
{
    public string Key { get; }
    public string Description { get; }

    private BlendMode(string key, string description)
    {
        Key = key;
        Description = description;
    }

    public static BlendMode Normal = new("norm", nameof(Normal));
    public static BlendMode Darken = new("dark", nameof(Darken));
    public static BlendMode Lighten = new("lite", nameof(Lighten));
    public static BlendMode Hue = new("hue ", nameof(Hue));
    public static BlendMode Saturation = new("sat ", nameof(Saturation));
    public static BlendMode Color = new("colr", nameof(Color));
    public static BlendMode Luminosity = new("lum ", nameof(Luminosity));
    public static BlendMode Multiply = new("mul ", nameof(Multiply));
    public static BlendMode Screen = new("scrn", nameof(Screen));
    public static BlendMode Dissolve = new("diss", nameof(Dissolve));
    public static BlendMode Overlay = new("over", nameof(Overlay));
    public static BlendMode HardLight = new("hLit", nameof(HardLight));
    public static BlendMode SoftLight = new("sLit", nameof(SoftLight));
    public static BlendMode Difference = new("diff", nameof(Difference));
    public static BlendMode Exclusion = new("smud", nameof(Exclusion));
    public static BlendMode ColorDodge = new("div", nameof(ColorDodge));
    public static BlendMode ColorBurn = new("idiv", nameof(ColorBurn));

    public static List<BlendMode> All = new()
    {
        Normal, Darken, Lighten, Hue, Saturation, Color, Luminosity, Multiply, Screen, Dissolve, Overlay, HardLight,
        SoftLight, Difference, Exclusion, ColorDodge, ColorBurn
    };

    public static BlendMode? FromKey(string key)
    {
        return All.Find(x => x.Key == key);
    }
}