Console.Write("Enter the first number: ");
var num1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the second number: ");
var num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    Console.WriteLine($"The first number {num1} is greater than the second number {num2}.");
}
else if (num2 > num1)
{
    Console.WriteLine($"The second number {num2} is greater than the first number {num1}.");
}
else
{
    Console.WriteLine($"The numbers are equal.");
}
