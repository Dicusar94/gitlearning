namespace GitLearn;

static class Program
{
    private static void Main()
    {
        Console.WriteLine("Two number sum calculator");
        GetInput("Enter the first value: ", out int firstValue);
        GetInput("Enter the second value: ", out int secondValue);
        var result = firstValue + secondValue;
        Console.WriteLine($"{firstValue} + {secondValue} = {result}");

        SecondProgram();
    }

    private static void GetInput(string message, out int value)
    {
        Console.Write(message);
        _ = int.TryParse(Console.ReadLine(), out value);
    }

    private static void SecondProgram()
    {
        Console.WriteLine("Hello, World!");
        Console.Write("What is your date of birth");
        var isDate = DateTime.TryParse(Console.ReadLine(), out DateTime dateOfBirth);
        if (isDate)
        {
            var daysOfLife = (DateTime.Now - dateOfBirth).Days;
            Console.WriteLine($"Days on earth = {daysOfLife}");
        }
    }
}