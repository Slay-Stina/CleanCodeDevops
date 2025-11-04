namespace PackagePriceCalculator.Models;

public class Square : Package
{
    public Square() : base()
    {
        Price = Price += 10000;
    }
}