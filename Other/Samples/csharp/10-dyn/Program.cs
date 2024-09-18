string data = "hello, world";
Console.WriteLine($"The data contains: {data}.");
Console.WriteLine($"The data length is {data.Length}.");

data = 42;
Console.WriteLine($"Now, the data is: {data}.");
Console.WriteLine($"The data length is {data.Length}.");

// object data = "hello, world";
// Console.WriteLine($"The data contains: {data}.");
// Console.WriteLine($"The data length is {((string)data).Length}.");

// data = 42;
// Console.WriteLine($"Now, the data is: {data}.");
// Console.WriteLine($"The data length is {data.Length}.");

// dynamic data = "hello, world";
// Console.WriteLine($"The data contains: {data}.");
// Console.WriteLine($"The data length is {data.Length}.");

// data = 42;
// Console.WriteLine($"Now, the data is: {data}.");
// Console.WriteLine($"The data length is {data.Length}."); // will crash, but will compile
