Console.Write("Enter a number: ");
var num = Math.Abs(long.Parse(Console.ReadLine()!));

long sum = 0;

// do
// {
//     sum += num % 10;
//     num /= 10;
// }
// while (num != 0);

while (num != 0)
{
    sum += num % 10;
    num /= 10;
}

Console.WriteLine($"The sum of all digits is {sum}");