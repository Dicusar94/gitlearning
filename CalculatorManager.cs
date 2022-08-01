namespace GitLearn;

public static class CalculatorManager
{
    public static void Addition()
    {
        Console.WriteLine("Two number addition");
        var numbers = GetUserNumbers();
        var result = numbers.Item1 + numbers.Item2;
        Console.WriteLine($"{numbers.Item1} + {numbers.Item2} = {result}");
    }

    public static void Subtraction()
    {
        Console.WriteLine("Two number subtraction");
        var numbers = GetUserNumbers();
        var result = numbers.Item1 - numbers.Item2;
        Console.WriteLine($"{numbers.Item1} - {numbers.Item2} = {result}");
    }

    private static void GetInput(string message, out int value)
    {
        Console.Write(message);
        _ = int.TryParse(Console.ReadLine(), out value);
    }

    private static Tuple<int, int> GetUserNumbers()
    {
        GetInput("Enter the first value: ", out int firstValue);
        GetInput("Enter the second value: ", out int secondValue);
        return new Tuple<int, int>(firstValue, secondValue);
    }
}