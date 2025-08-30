using System;

namespace PsdSharp.Types;

public struct Color
{
    public byte Alpha { get; }
    public byte Red { get; }
    public byte Green { get; }
    public byte Blue { get; }

    public Color(byte alpha, byte red, byte green, byte blue)
    {
        Alpha = alpha;
        Red = red;
        Green = green;
        Blue = blue;
    }

    public static Color FromCmyk(byte c, byte m, byte y, byte k)
    {
        var red = (byte)Math.Max(Math.Min(255 * (1 - c) * (1 - k), 0x255), 0x0);
        var green = (byte)Math.Max(Math.Min(255 * (1 - m) * (1 - k), 0x255), 0x0);
        var blue = (byte)Math.Max(Math.Min(255 * (1 - y) * (1 - k), 0x255), 0x0);
        
        return new Color(byte.MaxValue, red, green, blue);
    }
}