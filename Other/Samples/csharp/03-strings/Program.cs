// Option #1

Console.WriteLine("***************");
Console.WriteLine("*hello, world!*");
Console.WriteLine("***************");
Console.WriteLine();

// Option #2

Console.WriteLine("***************\n*hello, world!*\n***************\n");

// Option #3

Console.WriteLine(
    "***************\n" +
    "*hello, world!*\n" +
    "***************\n"
);

// Option #4

Console.WriteLine(
@"***************
*hello, world!*
***************
"
);

// Option #5 (C# 11 only, still in beta)

Console.WriteLine("""
   ***************
   *hello, world!*
   ***************
   """
);
