namespace CalculatorAppTests;

using CalculatorApp;

public class CalculatorTests
{
    private readonly Calculator _sut = new Calculator();
    
    [Fact]
    public void Add_TwoPlusTwo_ReturnsFour()
    {
        //Arrange
        int a = 2;
        int b = 2;
        int expected = 4;

        //Act
        int actual = _sut.Add(a, b);
        
        //Assert
        Assert.Equal(expected, actual);

    }
    
    [Fact]
    public void Subtract_FiveMinusThree_ReturnsTwo()
    {
        //Arrange
        int a = 5;
        int b = 3;
        int expected = 2;
        //Act
        int actual = _sut.Subtract(a, b);
        //Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Multiply_FiveTimesThree_ReturnsFifteen()
    {
        int a = 5;
        int b = 3;
        int expected = 15;
        int actual = _sut.Multiply(a, b);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide_SixByThree_ReturnsTwo()
    {
        int a = 6;
        int b = 3;
        int expected = 2;
        double actual = _sut.Divide(a, b);
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        int a = 5;
        int b = 0;
        Assert.Throws<DivideByZeroException>(() => _sut.Divide(a, b));
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    [InlineData(57, 13, 70)]
    [InlineData(6, 7, 13)]
    [InlineData(74, 12, 86)]
    public void CanAdd(int a, int b, int sum)
    {
        var expected = sum;
        var actual = _sut.Add(a, b);
        Assert.Equal(sum, actual);
    }
    
    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(9, 3, 3)]
    [InlineData(5, 0, double.NaN)]
    public void CanDivide(int a, int b, double expected)
    {
        if (b == 0)
            Assert.Throws<DivideByZeroException>(() => _sut.Divide(a, b));
        else
        {
            var result = _sut.Divide(a, b);
            Assert.Equal(expected, result);
        }
    }
}