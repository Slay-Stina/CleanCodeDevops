namespace PackagePriceCalculator.Models;

public class Square : Package
{
    public Square(int width, int height, double weight) : base(width, height, weight)
    {
        Price = Price += 10;
    }
}