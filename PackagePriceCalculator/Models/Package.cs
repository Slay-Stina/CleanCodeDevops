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

    public Package()
    {
        Width = Console.ReadLine().ToInt();
        Height = Console.ReadLine().ToInt();
        Volume = Width * Height;
        Weight = Console.ReadLine().ToInt() > 0 ? this.CheckAndReturnWeight() : throw new Exception("Invalid weight");
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