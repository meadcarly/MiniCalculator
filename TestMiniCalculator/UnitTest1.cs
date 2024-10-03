
using Mini_Calculator;
using Xunit;


namespace TestMiniCalculator;

public class Tests
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
}