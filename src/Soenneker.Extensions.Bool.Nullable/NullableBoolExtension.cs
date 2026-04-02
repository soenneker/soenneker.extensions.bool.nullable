using System.Diagnostics.Contracts;

namespace Soenneker.Extensions.Bool.Nullable;

/// <summary>
/// A collection of helpful bool? extension methods
/// </summary>
public static class NullableBoolExtension
{
    /// <summary>
    /// Shorthand for checking if a nullable bool is null or false
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [Pure]
    public static bool IsNullOrFalse(this bool? value)
    {
        return value != true;
    }

    /// <returns>"Yes" or "No" or "null"</returns>
    [Pure]
    public static string ToYesNoNullable(this bool? value)
    {
        if (!value.HasValue)
            return "Null";

        return value.Value ? "Yes" : "No";
    }

    /// <returns>"Yes" or "No" or "null"</returns>
    [Pure]
    public static string ToYesNoNullableLower(this bool? value)
    {
        if (!value.HasValue)
            return "null";

        return value.Value ? "yes" : "no";
    }
}