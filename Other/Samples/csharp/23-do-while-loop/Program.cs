var sum = 0;
var i = 0;

int grade;
do
{
    grade = int.Parse(Console.ReadLine()!);
    sum += grade;
    i++;
}
while (grade != 0);

i--;

if (i > 0)
{
    double avg = (double) sum / i;
    Console.WriteLine($"Среднее арифметическое {avg:0.0}");
}
else
{
    Console.WriteLine("Нет данных для расчёта");
}
