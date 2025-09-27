using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// CSS text decoration keywords in enumeration form.
/// </summary>
[Intellenum<string>]
public partial class TextDecorationStyleKeyword
{
    /// <summary>
    /// Draws a single line segment.
    /// This is the default style.
    /// </summary>
    public static readonly TextDecorationStyleKeyword Solid = new("solid");

    /// <summary>
    /// Draws two parallel lines.
    /// </summary>
    public static readonly TextDecorationStyleKeyword Double = new("double");

    /// <summary>
    /// Draws a dotted line.
    /// </summary>
    public static readonly TextDecorationStyleKeyword Dotted = new("dotted");

    /// <summary>
    /// Draws a dashed line.
    /// </summary>
    public static readonly TextDecorationStyleKeyword Dashed = new("dashed");

    /// <summary>
    /// Draws a wavy line.
    /// </summary>
    public static readonly TextDecorationStyleKeyword Wavy = new("wavy");

    public static implicit operator TextDecorationStyleKeyword(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}
