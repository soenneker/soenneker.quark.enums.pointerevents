using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Typed values for the CSS pointer-events property in .NET enumeration form.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class PointerEventsKeyword
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly PointerEventsKeyword None = new("none");
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly PointerEventsKeyword Auto = new("auto");
}
