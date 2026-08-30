[![](https://img.shields.io/nuget/v/soenneker.quark.enums.pointerevents.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.pointerevents/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.pointerevents/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.pointerevents/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.pointerevents/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.pointerevents/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.pointerevents.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.pointerevents/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.pointerevents/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.pointerevents/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.PointerEvents

Strongly typed CSS `pointer-events` values for Quark components and styles.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.PointerEvents
```

## Usage

```csharp
PointerEventsKeyword pointerEvents = PointerEventsKeyword.None;
string cssValue = pointerEvents.Value; // "none"
```

Use `None` when pointer input should pass through an element, such as a decorative overlay. Use `Auto` to restore normal hit testing. The type also includes CSS-wide values from `GlobalKeyword`.

## Values

| Member | CSS value | Behavior for HTML elements |
| --- | --- | --- |
| `None` | `none` | The element itself is not a pointer-event target. |
| `Auto` | `auto` | Uses normal browser hit testing. |

`pointer-events: none` does not disable keyboard focus, and descendants can still be targets if they override the property. Use semantic disabled state and accessibility attributes where appropriate.
