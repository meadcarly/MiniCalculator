using System.Runtime.InteropServices;
using Mini_Calculator;

namespace TestMini_Calculator;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 4, 7)]
    [InlineData(5, 7, 12)]

    public void AdditionTest(decimal firstInteger, decimal secondInteger, decimal expected)
    {
        //Arrange
        var basicMath = new BasicMaths();
        //Act
        var actual = basicMath.Addition(firstInteger, secondInteger);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 1, 0)]
    [InlineData(0, 1, -1)]
    [InlineData(5, 4, 1)]
    [InlineData(0, 2, -2)]
    [InlineData(163, 3, 160)]

    public void SubtractionTest(decimal firstInteger, decimal secondInteger, decimal expected)
    {
        //Arrange
        var basicMath = new BasicMaths();
        //Act
        var actual = basicMath.Subtraction(firstInteger, secondInteger);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0, 1, 0)]
    [InlineData(1, 0, 0)]
    [InlineData(1, 2, 2)]
    [InlineData(1, -1, -1)]
    [InlineData(-1, 5, -5)]
    [InlineData(-2, -2, 4)]
    [InlineData(3, 3, 9)]

    public void MultiplicationTest(decimal firstInteger, decimal secondInteger, decimal expected)
    {
        //Arrange
        var basicMath = new BasicMaths();
        //Act
        var actual = basicMath.Multiplication(firstInteger, secondInteger);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0, 1, 0)]
    [InlineData(1, 1, 1)]
    [InlineData(4, 2, 2)]
    [InlineData(16, 4, 4)]
    [InlineData(-16, 2, -8)]
    [InlineData(-30, -10, 3)]

    public void DivisionTest(decimal numerator, decimal denominator, decimal expected)
    {
        //Arrange
        var basicMath = new BasicMaths();
        //Act
        var actual = basicMath.Division(numerator, denominator);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(25, 63.5)]
    [InlineData(16, 40.64)]
    [InlineData(43.5, 110.49)]
    [InlineData(38.25, 97.155)]

    public void InchesToCentimetersTest(double inches, double expected)
    {
        //Arrange
        var conversionMath = new ConversionMaths();
        //Act
        var actual = conversionMath.InchesToCentimeters(inches);
        //Assert
        Assert.Equal(expected, actual);
    }
}