using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// CSS text decoration keywords in enumeration form.
/// </summary>
[Intellenum<string>]
public partial class TextDecorationStyle
{
    /// <summary>
    /// Draws a single line segment.
    /// This is the default style.
    /// </summary>
    public static readonly TextDecorationStyle Solid = new("solid");

    /// <summary>
    /// Draws two parallel lines.
    /// </summary>
    public static readonly TextDecorationStyle Double = new("double");

    /// <summary>
    /// Draws a dotted line.
    /// </summary>
    public static readonly TextDecorationStyle Dotted = new("dotted");

    /// <summary>
    /// Draws a dashed line.
    /// </summary>
    public static readonly TextDecorationStyle Dashed = new("dashed");

    /// <summary>
    /// Draws a wavy line.
    /// </summary>
    public static readonly TextDecorationStyle Wavy = new("wavy");

    public static implicit operator TextDecorationStyle(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}
