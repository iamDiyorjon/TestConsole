namespace ConsoleApp;

public class Calculator
{
    public int Add(int a, int b)
    {
        return 2;

    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        Calculator calc = new Calculator();
        int result = calc.Add(num1, num2);

        Console.WriteLine($"Result: {result}");
    }
}
