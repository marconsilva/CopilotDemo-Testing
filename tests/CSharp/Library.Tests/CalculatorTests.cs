using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library; // Update with the actual namespace of your Library project

namespace Library.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_ShouldReturnSum_WhenTwoNumbersAreProvided()
        {
            // Arrange
            var number1 = 5;
            var number2 = 3;

            // Act
            var result = _calculator.Add(number1, number2);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnDifference_WhenTwoNumbersAreProvided()
        {
            // Arrange
            var number1 = 5;
            var number2 = 3;

            // Act
            var result = _calculator.Subtract(number1, number2);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnProduct_WhenTwoNumbersAreProvided()
        {
            // Arrange
            var number1 = 5;
            var number2 = 3;

            // Act
            var result = _calculator.Multiply(number1, number2);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Divide_ShouldReturnQuotient_WhenDividingByNonZeroNumber()
        {
            // Arrange
            var number1 = 6;
            var number2 = 3;

            // Act
            var result = _calculator.Divide(number1, number2);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ShouldThrowDivideByZeroException_WhenDividingByZero()
        {
            // Arrange
            var number1 = 6;
            var number2 = 0;

            // Act
            _calculator.Divide(number1, number2);
        }
    }
}