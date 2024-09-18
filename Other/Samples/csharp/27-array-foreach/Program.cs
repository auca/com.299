Console.Write("Enter the number of elements in the array: ");
var elementCount = uint.Parse(Console.ReadLine()!);

int[] nums = new int[elementCount];
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"Enter the value of element at index {i}: ");
    nums[i] = int.Parse(Console.ReadLine()!);
}

if (nums.Length != 0)
{
    int min = nums[0], max = nums[0];
    foreach (var num in nums)
    {
        if (num > max) max = num;
        if (num < min) min = num;
    }

    Console.WriteLine(
        $"Min: {min}\n" +
        $"Max: {max}"
    );
}
