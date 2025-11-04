namespace PackagePriceCalculator.Interfaces;

public interface IPackage
{
    double Price { get; set; }
    int Width { get; set; }
    int Height { get; set; }
    double Volume { get; set; }
    int Weight { get; set; }
    int SmallPackagePrice(int weight);
}