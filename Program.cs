Console.WriteLine("Hello, World!");
Console.Write("What is your date of birth");
var isDate = DateTime.TryParse(Console.ReadLine(), out DateTime dateOfBirth);
if (isDate)
{
    var daysOfLife = (DateTime.Now - dateOfBirth).Days;
    Console.WriteLine($"Days on earth = {daysOfLife}");
}
