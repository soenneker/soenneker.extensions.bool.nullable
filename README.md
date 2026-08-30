[![](https://img.shields.io/nuget/v/soenneker.extensions.bool.nullable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.bool.nullable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.bool.nullable/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.bool.nullable/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.bool.nullable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.bool.nullable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.bool.nullable/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.bool.nullable/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Bool.Nullable

Checks nullable Booleans and formats all three states as fixed English text.

## Installation

```bash
dotnet add package Soenneker.Extensions.Bool.Nullable
```

## Usage

```csharp
using Soenneker.Extensions.Bool.Nullable;

bool? value = null;

bool missingOrDisabled = value.IsNullOrFalse(); // true
string display = value.ToYesNoNullable();       // "Null"
string lower = value.ToYesNoNullableLower();    // "null"
```

## Exact mappings

| Input | `IsNullOrFalse()` | `ToYesNoNullable()` | `ToYesNoNullableLower()` |
| --- | --- | --- | --- |
| `true` | `false` | `"Yes"` | `"yes"` |
| `false` | `true` | `"No"` | `"no"` |
| `null` | `true` | `"Null"` | `"null"` |

`IsNullOrFalse()` deliberately collapses `false` and `null`. Do not use it when “not supplied” and “explicitly disabled” have different domain meanings; check `HasValue` or pattern-match the three states instead.

The text methods are deterministic and culture-invariant. They are intended for simple display or fixed text contracts, not localization, parsing, or JSON serialization. They return the literal word `Null`, not a null string reference.
