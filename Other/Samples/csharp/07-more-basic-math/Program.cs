Console.Write("Enter the first number: ");
var num1 = double.Parse(Console.ReadLine()!);

Console.Write("Enter the second number: ");
var num2 = double.Parse(Console.ReadLine()!);

double res;

res = num1 + num2;
Console.WriteLine($"{num1} + {num2} = {res:0.000}");

res = num1 - num2;
Console.WriteLine($"{num1} - {num2} = {res:0.000}");

res = num1 * num2;
Console.WriteLine($"{num1} × {num2} = {res:0.000}");

res = num1 / num2;
Console.WriteLine($"{num1} ÷ {num2} = {res:0.000}");

res = num1 % num2;
Console.WriteLine($"{num1} % {num2} = {res:0.000}");

res = Math.Pow(num1, num2);
Console.WriteLine($"{num1} ** {num2} = {res:0.000}");
