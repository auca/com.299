const int MinTestValue = 0;
const int MaxTestValue = 10;

Console.Write("Enter the number of tests: ");
var testCount = uint.Parse(Console.ReadLine()!);

var randomGen = new Random();

uint correctAnswerCount = 0;
uint incorrectAnswerCount = 0;

// {
//     uint i = 1;
//     while (i <= testCount)
//     {
//         var num1 = randomGen.Next(MinTestValue, MaxTestValue + 1);
//         var num2 = randomGen.Next(MinTestValue, MaxTestValue + 1);
//         Console.Write($"{num1} + {num2} = ");
//         var answer = int.Parse(Console.ReadLine()!);
//         if (num1 + num2 == answer)
//         {
//             correctAnswerCount++;
//         }
//         else
//         {
//             incorrectAnswerCount++;
//         }
//         i++;
//     }
// }

// while (testCount-- > 0)
// {
//     var num1 = randomGen.Next(MinTestValue, MaxTestValue + 1);
//     var num2 = randomGen.Next(MinTestValue, MaxTestValue + 1);
//     Console.Write($"{num1} + {num2} = ");
//     var answer = int.Parse(Console.ReadLine()!);
//     if (num1 + num2 == answer)
//     {
//         correctAnswerCount++;
//     }
//     else
//     {
//         incorrectAnswerCount++;
//     }
// }

for (uint i = 0; i < testCount; i++)
{
    var num1 = randomGen.Next(MinTestValue, MaxTestValue + 1);
    var num2 = randomGen.Next(MinTestValue, MaxTestValue + 1);
    Console.Write($"{num1} + {num2} = ");
    var answer = int.Parse(Console.ReadLine()!);
    if (num1 + num2 == answer)
    {
        correctAnswerCount++;
    }
    else
    {
        incorrectAnswerCount++;
    }
}

Console.WriteLine($"Correct answers: {correctAnswerCount}");
Console.WriteLine($"Incorrect answers: {incorrectAnswerCount}");
