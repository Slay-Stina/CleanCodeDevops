namespace PackagePriceCalculator.Extensions;

using Models;

public static class PackageExtension
{
    public static double CheckAndReturnWeight(this double weight)
    {
        return weight < 2 ?
            2 
            : weight > 20 
            ? throw new Exception("Package too heavy") 
            : weight;
    }
    public static bool IsSmallPackage(this Package package)
    {
        if (package.Width < 30 && package.Width >= package.Height)
            return true;
        if (package.Height < 30 && package.Height >= package.Width)
            return true;
        return false;
    }
}