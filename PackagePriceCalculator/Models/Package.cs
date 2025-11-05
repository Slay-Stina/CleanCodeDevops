namespace PackagePriceCalculator.Models;

using Extensions;
using Spectre.Console;

public class Package
{
    public int Price { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Volume { get; set; }
    public int Weight { get; set; }

    protected Package(int width, int height, int weight)
    {
        Width = width;
        Height = height;
        Volume = Width * Height;
        Weight = weight;
        this.CheckAndReturnWeight();
        Price = this.IsSmallPackage()
            ? SmallPackagePrice(Weight)
            : Volume * Weight;
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