using DemoLibrary;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4,3,7)] // populate method
        [InlineData(21,5.25,26.25)]
        [InlineData(double.MaxValue,5, double.MaxValue)] // Also test the extreme or unexpected case and not just simple cases
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory] // Theory allows us to pass in data and run tests multiple times with different data sets
        [InlineData(8, 4, 2)] 
        public void Devide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);

            Assert.Equal(expected, actual);
        }

        [Fact] // Just to specify that a method is a test and that it should be picked up the test runner
        public void Devide_DevideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(15, 0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
