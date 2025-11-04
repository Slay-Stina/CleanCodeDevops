namespace CalculatorAppTests;

using CalculatorApp;

public class AdvancedCalculatorFixture : IClassFixture<AdvancedCalculator>
{
    public AdvancedCalculator Calculator {get; set;} = new  AdvancedCalculator();
}