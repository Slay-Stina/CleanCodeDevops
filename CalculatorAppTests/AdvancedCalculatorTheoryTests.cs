namespace CalculatorAppTests;

using CalculatorApp;

public class AdvancedCalculatorTheoryTests
{
    [Theory]
    [InlineData("Daniel", true)]
    [InlineData("StudentCalc", false)]
    [InlineData("TI-84 Plus", true)]
    public void OwnerName_IsScientificFlagMatches(string owner, bool expectedScientific)
    {
        var sut = new AdvancedCalculator()
        {
            Model = owner,
            IsScientific = expectedScientific
        };
        var actual = sut.IsScientific;

        Assert.Equal(expectedScientific, actual);
    }
}