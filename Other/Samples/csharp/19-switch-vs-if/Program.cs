var random = new Random();

// string rank;
int rankID = random.Next(1, 14);
// switch (rankID)
// {
//     case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9: case 10:
//         rank = $"{rankID}";
//         break;
//     case 1:  rank = "Ace";   break;
//     case 11: rank = "Jack";  break;
//     case 12: rank = "King";  break;
//     case 13: rank = "Queen"; break;
// }

string rank = rankID switch
{
    2 => $"{rankID}",
    3 => $"{rankID}",
    4 => $"{rankID}",
    5 => $"{rankID}",
    6 => $"{rankID}",
    7 => $"{rankID}",
    8 => $"{rankID}",
    9 => $"{rankID}",
    10 => $"{rankID}",
    1 => "Ace",
    11 => "Jack",
    12 => "King",
    13 => "Queen",
    _ => ""
};

int suitID = random.Next(1, 5);
string suit = "";
if (suitID == 1)      suit = "club";
else if (suitID == 2) suit = "diamonds";
else if (suitID == 3) suit = "hearts";
else if (suitID == 4) suit = "spades";

Console.WriteLine($"You have selected \"{rank} of {suit}\".");
