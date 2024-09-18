Console.Write("Enter the first number: ");
var num1 = double.Parse(Console.ReadLine()!);

Console.Write("Enter the second number: ");
var num2 = double.Parse(Console.ReadLine()!);

double sum = num1 + num2;
Console.WriteLine(num1 + " + " + num2 + " = " + sum);
Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
Console.WriteLine($"{num1} + {num2} = {sum:0.000}"); // round sum to three digits after .
