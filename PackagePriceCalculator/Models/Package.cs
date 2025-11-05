namespace PackagePriceCalculator.Models;

using Extensions;
using Spectre.Console;

public class Package
{
    public double Price { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public double Volume { get; set; }
    public int Weight { get; set; }

    public Package()
    {
        Width = AnsiConsole.Ask<int>("Width: ");
        Height = AnsiConsole.Ask<int>("Height: ");
        Volume = Width * Height;
        Weight = AnsiConsole.Ask<int>("Weight: ");
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