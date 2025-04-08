using System;
using Xunit;

namespace Library.Tests
{
    public class StringUtilitiesTests
    {
        private readonly StringUtilities _stringUtilities;

        public StringUtilitiesTests()
        {
            _stringUtilities = new StringUtilities();
        }

        [Fact]
        public void Concatenate_ShouldReturnCombinedString()
        {
            // Arrange
            var str1 = "Hello";
            var str2 = "World";

            // Act
            var result = _stringUtilities.Concatenate(str1, str2);

            // Assert
            Assert.Equal("HelloWorld", result);
        }

        [Fact]
        public void Split_ShouldReturnArrayOfStrings()
        {
            // Arrange
            var input = "Hello,World";
            var expected = new[] { "Hello", "World" };

            // Act
            var result = _stringUtilities.Split(input, ',');

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Concatenate_WithNull_ShouldReturnOtherString()
        {
            // Arrange
            string str1 = null;
            string str2 = "World";

            // Act
            var result = _stringUtilities.Concatenate(str1, str2);

            // Assert
            Assert.Equal("World", result);
        }

        [Fact]
        public void Split_WithEmptyString_ShouldReturnEmptyArray()
        {
            // Arrange
            var input = "";

            // Act
            var result = _stringUtilities.Split(input, ',');

            // Assert
            Assert.Empty(result);
        }
    }
}