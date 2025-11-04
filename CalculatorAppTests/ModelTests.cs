namespace CalculatorAppTests;

[Collection(nameof(AdvancedCalculatorCollection))]
public class ModelTests
{
    private readonly AdvancedCalculatorFixture _fixture;
    public ModelTests(AdvancedCalculatorFixture fixture)
    {
        _fixture = fixture;
    }
    
    [Fact]
    public void Model_ContainsTI()
    {
        var expectedSubstring = "TI";
        var actual = _fixture.Calculator.Model;
        Assert.Contains(expectedSubstring, actual);
    }
    
    [Fact]
    public void IsScientific_IsTrue()
    {
        var actual = _fixture.Calculator.IsScientific;
        Assert.True(actual);
    }
}