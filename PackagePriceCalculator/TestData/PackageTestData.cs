namespace PackagePriceCalculator.TestData;

using System.Collections;
using Models;

public class PackageTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [new Package(10, 20, 30), false];
        yield return [new Square(30, 30, 10), true];

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}