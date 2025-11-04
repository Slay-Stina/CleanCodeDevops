namespace CalculatorApp;

public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;

    public double Divide(int a, int b)
    {
        if (a == 0 || b == 0)
            throw new DivideByZeroException();
        return (double)a / b;
    }
}