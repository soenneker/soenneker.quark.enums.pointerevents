using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents a CSS <c>pointer-events</c> keyword.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class PointerEventsKeyword
{
    /// <summary>
    /// Prevents the element itself from being a pointer-event target.
    /// </summary>
    public static readonly PointerEventsKeyword None = new("none");
    /// <summary>
    /// Uses normal browser hit testing.
    /// </summary>
    public static readonly PointerEventsKeyword Auto = new("auto");
}
