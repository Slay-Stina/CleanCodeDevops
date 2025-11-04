namespace CalculatorAppTests;

[Collection(nameof(AdvancedCalculatorCollection))]
public class OwnerTests
{
    private readonly AdvancedCalculatorFixture _fixture;
    public OwnerTests(AdvancedCalculatorFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Owner_IsDaniel()
    {
        var expected = "Daniel";
        var actual = _fixture.Calculator.Owner;
        Assert.Equal(expected, actual);
    }
}