namespace PackagePriceCalculator.Models;

using Extensions;

public class Package
{
    public double Price { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Volume { get; set; }
    public double Weight { get; set; }

    public Package(int width, int height, double weight)
    {
        Width = width;
        Height = height;
        Volume = Width * Height;
        Weight = weight.CheckAndReturnWeight();
        Price = this.IsSmallPackage()
            ? SmallPackagePrice(Weight)
            : Volume * Weight;
    }

    public double SmallPackagePrice(double weight)
    {
        if (weight == 2.0)
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