Console.Write("Введите количество бросков: ");
var throwCount = uint.Parse(Console.ReadLine()!);

uint[] counters = new uint[13];

var randomGen = new Random();
for (int i = 0; i < throwCount; i++)
{
    var die1 = randomGen.Next(1, 6 + 1);
    var die2 = randomGen.Next(1, 6 + 1);
    counters[die1 + die2]++;
}

for (uint i = 2; i < counters.Length; i++)
{
    Console.WriteLine($"{i}: {counters[i]}");
}
