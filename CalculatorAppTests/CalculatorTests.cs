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
}