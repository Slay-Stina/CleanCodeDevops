namespace PackagePriceTests;

using PackagePriceCalculator.Models;

public class PackageTests
{
    private const int SmallPackagePriceUnderTwentyKg = 79;
    private const int SmallPackagePriceUnderTenKg = 49;
    private const int SmallPackagePriceTwoKg = 29;
    
    [Theory]
    [InlineData(10, 32, 20)]
    [InlineData(40, 10, 11.5)]
    [InlineData(40, 15, 5)]
    public void Square_PriceCalc_ReturnsCorrectPrice(int width, int height, double weight)
    {
        //Arrange
        var expected = width * height * weight + 10;
        var sut = new Square(width, height, weight);
        
        //Act
        var actual = sut.Price;
        
        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(SmallPackagePriceUnderTwentyKg, 15)]
    [InlineData(SmallPackagePriceUnderTenKg, 5)]
    [InlineData(SmallPackagePriceTwoKg, 2)]
    public void Square_SmallPackagePrice_ReturnsCorrectPrice( int smallPackagePrice,  int weight)
    {
        var width = 1;
        var height = 1;
        var sut = new Square(width, height, weight);
        var expected = smallPackagePrice + 10;
        
        var actual = sut.Price;
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(SmallPackagePriceUnderTwentyKg, 15)]
    [InlineData(SmallPackagePriceUnderTenKg, 5)]
    [InlineData(SmallPackagePriceTwoKg, 2)]
    public void Pipe_SmallPackagePrice_ReturnsCorrectPrice( int smallPackagePrice,  int weight)
    {
        var width = 1;
        var height = 1;
        var sut = new Pipe(width, height, weight);
        var expected = smallPackagePrice;
        
        var actual = sut.Price;
        
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(1.4)]
    [InlineData(1.6)]
    public void Package_IsTooLight_ReturnsTwo(double weight)
    {
        var width = 1;
        var height = 1;
        var sut = new Package(width, height, weight);
        var expected = 2;
        
        var actual = sut.Weight;
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Package_IsTooHeavy_ThrowsException()
    {
        var width = 1;
        var height = 1;
        var weight = 100;
        
        Assert.Throws<Exception>(() => new Package(width, height, weight));
    }
}