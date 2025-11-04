namespace PackagePriceCalculator.Extensions;

public static class InputExtensions
{
    public static int ToInt(this string? value)
    {
        return int.TryParse(value, out int result) ? result : throw new Exception("Input must be a number.");
    }
}