using DEPI_Session09;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineCalculatorTest
{
    public class FineCalculatorTest
    {
        private readonly FineCalculator _calculator;

        public FineCalculatorTest()
        {
            _calculator = new FineCalculator();
        }

        // Add
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_ShouldReturnNotEqual()
        {
            int a = 5;
            int b = 3;
            int result = _calculator.Add(a, b);

            Assert.NotEqual(10, result);
        }


        // Subtract
        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            int a = 20, b = 10;

            int result = _calculator.Subtract(a, b);

            Assert.Equal(10, result);
        }


        // Multiply
        [Theory]
        [InlineData(2, 3)]
        [InlineData(5, 4)]
        [InlineData(-2, 3)]
        public void Multiply_ShouldReturnNotEqual(int a, int b)
        {
            int result = _calculator.Multiply(a, b);

            Assert.NotEqual(100, result);
        }


        // Divide
        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            int a = 10;
            int b = 3;

            Assert.Throws<DivideByZeroException>(
                () => _calculator.Divide(a, b));
        }
    }
}
