namespace EmployeeAccess.TestData;

using System.Collections;
using Models;

public class EmployeeAccessTestData : IEnumerable<object[]> {
    public IEnumerator<object[]> GetEnumerator() {
        yield return new object[] { new Employee { Name = "Anna", Role = "Manager", IsClockedIn = true }, true };
        yield return new object[] { new Employee { Name = "Erik", Role = "Staff", IsClockedIn = true }, false };
        yield return new object[] { new Employee { Name = "Lisa", Role = "Manager", IsClockedIn = false }, false };
        yield return new object[] { new Employee { Name = "Tom", Role = "Staff", IsClockedIn = false }, false };
    }

    // Explicit interface implementation
    // Your class already implements IEnumerable<object[]>, which is the generic version. But [ClassData] expects the class to also implement the non-generic IEnumerable interface.

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}