using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// Typed values for the CSS pointer-events property in .NET enumeration form.
/// </summary>
[Intellenum<string>]
public sealed partial class PointerEvents
{
    public static readonly PointerEvents None = new("none");
    public static readonly PointerEvents Auto = new("auto");

    public static implicit operator PointerEvents(GlobalKeyword style) => new(style.Value);
}
