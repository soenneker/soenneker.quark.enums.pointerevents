using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// Typed values for the CSS pointer-events property in .NET enumeration form.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class PointerEventsKeyword
{
    public static readonly PointerEventsKeyword None = new("none");
    public static readonly PointerEventsKeyword Auto = new("auto");
}
