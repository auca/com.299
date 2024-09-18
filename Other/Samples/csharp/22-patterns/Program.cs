int? maybe = null;
if (maybe is int number)
{
    Console.WriteLine($"The nullable int 'maybe' has the value {number}");
}
else
{
    Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
}

// Console.Write("Temperature in degrees Fahrenheit: ");
// var degF = double.Parse(Console.ReadLine()!);
// var waterState = degF switch
// {
//     (> 32) and (< 212) => "liquid",
//     < 32 => "solid",
//     > 212 => "gas",
//     32 => "solid/liquid transition",
//     212 => "liquid / gas transition",
// };

// Console.WriteLine(waterState);
