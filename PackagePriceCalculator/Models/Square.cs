namespace PackagePriceCalculator.Models;

public class Square : Package
{
    public Square()
    {
        Price = Price += 10;
    }
}