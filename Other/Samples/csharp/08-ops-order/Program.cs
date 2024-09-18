Console.Write("Temperature in degrees Fahrenheit: ");
var degF = double.Parse(Console.ReadLine()!);
var degC = 5 / 9 * (degF - 32.0);
// var degC = (double) 5 / 9 * (degF - 32.0);
// var degC = 5.0 / 9.0 * (degF - 32.0);
// var degC = (degF - 32.0) * 5 / 9;

Console.WriteLine($"Temperature in degrees Celsius: {degC:0.00}");