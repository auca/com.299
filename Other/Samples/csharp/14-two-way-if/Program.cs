Console.Write("Enter a number: ");
var num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0)
{
    Console.WriteLine($"The number {num} is even.");
}
else
{
    Console.WriteLine($"The number {num} is odd.");
}
