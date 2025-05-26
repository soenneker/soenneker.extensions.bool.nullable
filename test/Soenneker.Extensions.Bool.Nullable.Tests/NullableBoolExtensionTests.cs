using AwesomeAssertions;
using Xunit;

namespace Soenneker.Extensions.Bool.Nullable.Tests;

public class NullableBoolExtensionTests
{
    [Fact]
    public void IsNullOrFalse_ShouldReturnTrue_WhenValueIsNull()
    {
        // Arrange
        bool? value = null;

        // Act
        var result = value.IsNullOrFalse();

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void IsNullOrFalse_ShouldReturnTrue_WhenValueIsFalse()
    {
        // Arrange
        bool? value = false;

        // Act
        var result = value.IsNullOrFalse();

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void IsNullOrFalse_ShouldReturnFalse_WhenValueIsTrue()
    {
        // Arrange
        bool? value = true;

        // Act
        var result = value.IsNullOrFalse();

        // Assert
        result.Should().BeFalse();
    }
}