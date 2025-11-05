namespace PackagePriceCalculator.Extensions;

using Models;

public static class PackageExtension
{
    public static int CheckAndReturnWeight(this Package package)
    {
        return package.Weight < 2 
            ? 2 
            : package.Weight > 20 
            ? throw new Exception("Package too heavy") 
            : package.Weight;
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