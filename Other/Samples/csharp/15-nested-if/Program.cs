Console.Write("Enter the first number: ");
var num1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the second number: ");
var num2 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the third number: ");
var num3 = int.Parse(Console.ReadLine()!);

int max;
if (num1 > num2)
{
    if (num1 > num3)
    {
        max = num1;
    }
    else
    {
        max = num3;
    }
}
else
{
    if (num2 > num3)
    {
        max = num2;
    }
    else
    {
        max = num3;
    }
}

// int max = num1;
// if (num2 > max) max = num2;
// if (num3 > max) max = num3;

Console.WriteLine($"The maximum value is {max}.");
