public class Program
{
    static void ReadValues(out int num1, out int num2)
    {
        Console.Write("Enter the first value: ");
        num1 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the second value: ");
        num2 = int.Parse(Console.ReadLine()!);
    }

    static void Swap(ref int num1, ref int num2)
    {
        // var temp = num1;
        // num1 = num2;
        // num2 = temp;

        (num1, num2) = (num2, num1);
    }

    static void Main(string[] args)
    {
        int a, b;
        ReadValues(out a, out b);

        Console.WriteLine($"Before swap: a = {a}; b = {b};");
        Swap(ref a, ref b);
        Console.WriteLine($"After swap: a = {a}; b = {b};");
    }
}
