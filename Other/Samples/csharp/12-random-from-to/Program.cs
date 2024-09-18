Console.Write("Min: ");
var min = int.Parse(Console.ReadLine()!);

Console.Write("Max: ");
var max = int.Parse(Console.ReadLine()!);

var res = new Random().Next(min, max + 1);
Console.WriteLine("Random from {0} to {1}: {2}", min, max, res);