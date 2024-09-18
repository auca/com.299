Console.Write("Enter a real number: ");
var num = double.Parse(Console.ReadLine()!);

var res = num;
if (num < 0)
{
    res *= -1;
}

// if (num < 0) res *= -1;

Console.WriteLine($"|{num}| = {res}");