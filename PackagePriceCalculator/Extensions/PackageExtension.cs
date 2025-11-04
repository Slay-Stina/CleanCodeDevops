namespace PackagePriceCalculator.Extensions;

using Interfaces;
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
    public static bool IsSmallPackage(this IPackage package)
    {
        return (package.Width < 30 || package.Height < 30)
               && (package.Width < package.Height || package.Height < package.Width);
    }
}