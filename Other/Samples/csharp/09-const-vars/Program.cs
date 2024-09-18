const double MetersInFoot = 0.305;

Console.Write("Enter the length in feet: ");
var feet = double.Parse(Console.ReadLine()!);

double meters = feet * MetersInFoot;
Console.WriteLine($"{feet:0.00} ft = {meters:0.00} m");
