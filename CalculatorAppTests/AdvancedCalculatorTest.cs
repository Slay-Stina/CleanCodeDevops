namespace CalculatorAppTests;

using CalculatorApp;

public class AdvancedCalculatorTest : IClassFixture<AdvancedCalculatorFixture>
{
    private readonly AdvancedCalculatorFixture _fixture;
    private readonly AdvancedCalculator _sut;
    public AdvancedCalculatorTest(AdvancedCalculatorFixture fixture)
    {
        _fixture = fixture;
        _sut = _fixture.Calculator;
    }
}