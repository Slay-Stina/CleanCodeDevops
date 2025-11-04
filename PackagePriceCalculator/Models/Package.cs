namespace PackagePriceCalculator.Models;

using Extensions;
using Interfaces;

public class Package : IPackage
{
    public double Price { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public double Volume { get; set; }
    public int Weight { get; set; }

    public Package(int width, int height, double weight)
    {
        Width = width;
        Height = height;
        Volume = width * height;
        Weight = this.CheckAndReturnWeight();
        Price = this.IsSmallPackage()
            ? SmallPackagePrice(Weight)
            : Volume * weight;
    }

    public int SmallPackagePrice(int weight)
    {
        if (weight == 2)
            return 29;
        if (weight < 10)
            return 49;
        if (weight <= 20)
            return 79;
        else
        {
            throw new Exception("Problem with small price");
        }
    }
}