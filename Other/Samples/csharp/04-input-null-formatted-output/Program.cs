string name; // string?
Console.Write("What is your name? ");
name = Console.ReadLine()!;
// Option #1
Console.WriteLine("Hello, " + name + "!");
// Option #2
Console.WriteLine("Hello, {0}!", name);
// Option #3
Console.WriteLine($"Hello, {name}!");