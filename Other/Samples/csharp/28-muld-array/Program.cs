int[,] squareTable = new int[10, 10];
for (int i = 0; i < squareTable.GetLength(0); i++) {
    for (int j = 0; j < squareTable.GetLength(1); j++) {
        squareTable[i, j] = (i + 1) * (j + 1);
    }
}

for (int i = 0; i < squareTable.GetLength(0); i++) {
    for (int j = 0; j < squareTable.GetLength(1); j++) {
        Console.Write($"{squareTable[i, j],4} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

var random = new Random();

int[][] jaggedTable = new int[10][];
for (int i = 0; i < jaggedTable.Length; i++) {
    jaggedTable[i] = new int[random.Next(1, 10)];
    for (int j = 0; j < jaggedTable[i].Length; j++) {
        jaggedTable[i][j] = j + 1;
    }
}

for (int i = 0; i < jaggedTable.Length; i++) {
    for (int j = 0; j < jaggedTable[i].Length; j++) {
        Console.Write($"{jaggedTable[i][j],4} ");
    }
    Console.WriteLine();
}
