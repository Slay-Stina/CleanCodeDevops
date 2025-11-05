namespace EmployeeAccess.TestData;

using System.Collections;
using System.Text.Json;
using Models;

public class EmployeeAccessJsonTestData : IEnumerable<object[]>
{
    private const string FilePath = "TestData/employee_access_cases.json";
    public IEnumerator<object[]> GetEnumerator()
    {
        foreach (var testCase in LoadFromJson())
        {
            yield return new object[] { testCase.Employee, testCase.Expected };
        }
    }

    private IEnumerable<EmployeeAccessCase> LoadFromJson()
    {
        if (File.Exists(FilePath))
        {
            var json = File.ReadAllText(FilePath);
            var cases = JsonSerializer.Deserialize<List<EmployeeAccessCase>>(json, 
                new  JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return cases ?? Enumerable.Empty<EmployeeAccessCase>();
        }
        else
            throw  new FileNotFoundException("Employee access cases not found");
            
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private class EmployeeAccessCase
    {
        public Employee Employee { get; set; }
        public bool Expected { get; set; }
    }
}