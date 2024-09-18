Console.Write("Year: ");
var year = int.Parse(Console.ReadLine()!);

Console.Write("Month: ");
var month = int.Parse(Console.ReadLine()!);

string msg;
switch (month) {
    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
        msg = "31";
        break;
    case 4: case 6: case 9: case 11:
        msg = "30";
        break;
    case 2:
        // if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) {
        //     msg = "29";
        // } else {
        //     msg = "28";
        // }
        bool isLeapYear = year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        msg = isLeapYear ? "29" : "28";
        break;
    default:
        msg = "Invalid month number";
        break;
}

Console.WriteLine(msg);