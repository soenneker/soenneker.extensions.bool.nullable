using System.Diagnostics.Contracts;

namespace Soenneker.Extensions.Bool.Nullable;

/// <summary>
/// Provides checks and fixed English formatting for nullable Boolean values.
/// </summary>
public static class NullableBoolExtension
{
    /// <summary>
    /// Returns whether the value is either <see langword="null"/> or <see langword="false"/>.
    /// </summary>
    /// <param name="value">The nullable Boolean to check.</param>
    /// <returns><see langword="true"/> unless <paramref name="value"/> is explicitly <see langword="true"/>.</returns>
    [Pure]
    public static bool IsNullOrFalse(this bool? value)
    {
        return value != true;
    }

    /// <summary>
    /// Converts a nullable Boolean to <c>Yes</c>, <c>No</c>, or <c>Null</c>.
    /// </summary>
    /// <param name="value">The nullable Boolean value to format.</param>
    /// <returns><c>Yes</c>, <c>No</c>, or <c>Null</c>.</returns>
    [Pure]
    public static string ToYesNoNullable(this bool? value)
    {
        if (!value.HasValue)
            return "Null";

        return value.Value ? "Yes" : "No";
    }

    /// <summary>
    /// Converts a nullable Boolean to <c>yes</c>, <c>no</c>, or <c>null</c>.
    /// </summary>
    /// <param name="value">The nullable Boolean value to format.</param>
    /// <returns><c>yes</c>, <c>no</c>, or <c>null</c>.</returns>
    [Pure]
    public static string ToYesNoNullableLower(this bool? value)
    {
        if (!value.HasValue)
            return "null";

        return value.Value ? "yes" : "no";
    }
}
