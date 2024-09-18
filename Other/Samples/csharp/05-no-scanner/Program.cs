Console.Write("Enter the radius and length of a cylinder: ");
string[] parts = Console.ReadLine()!.Split(); // "5.5 12" -> {"5.5", "12"}
var radius = double.Parse(parts[0]);
var length = double.Parse(parts[1]);

double area = radius * radius * Math.PI;
double volume = area * length;
Console.WriteLine(
    $"Area: {area}\n" +
    $"Volume: {volume}"
);
