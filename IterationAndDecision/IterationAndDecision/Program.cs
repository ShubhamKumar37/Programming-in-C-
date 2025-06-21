//for (int i = 0; i < 10; i++) Console.Write($"{i + 1} ");

//string[] arr = { "Shubham", "Kumar", "Sparsh", "Shivam" };
//foreach (string i in arr) Console.Write($"{i} ");

//string userIsDone = "";
//while (userIsDone.ToLower() != "yes")
//{
//    Console.WriteLine("In while loop");
//    Console.Write("Are you done? [yes] [no]: ");
//    userIsDone = Console.ReadLine();
//}

//IsPatternMatching(); static void IsPatternMatching()
//{
//    object obj1 = 123;
//    object obj2 = "Shubham";

//    if (obj2 is string) Console.Write($"This is a string = {obj2}"); // Here we can create a variable which is in below statement
//    else if (obj1 is int myObj2) Console.Write($"This is a int = {myObj2}");
    
//}


//ExecutePatternMatchingSwitchWithWhen(); static void ExecutePatternMatchingSwitchWithWhen()
//{
//    Console.WriteLine("1 [C#], 2 [VB]");
//    Console.Write("Please pick your language preference: ");
//    object langChoice = Console.ReadLine();
//    var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;
//    switch (choice)
//    {
//        case int i when i == 2:
//        case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
//            Console.WriteLine("VB: OOP, multithreading, and more!");
//            break;
//        case int i when i == 1:
//        case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
//            Console.WriteLine("Good choice, C# is a fine language.");
//            break;
//        default:
//            Console.WriteLine("Well...good luck with that!");
//            break;
//    }
//    Console.WriteLine();
//}

static string ColorScheme(string s)
{
    return s switch
    {
        "Red" => "This is red",
        "Green" => "This is green",
        _ => "This is nothing"
    };
}
Console.WriteLine(ColorScheme("Green"));

Console.WriteLine(RockPaperScissors("rock", "paper"));  static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins.",
        ("rock", "scissors") => "Rock wins.",
        ("paper", "rock") => "Paper wins.",
        ("paper", "scissors") => "Scissors wins.",
        ("scissors", "rock") => "Rock wins.",
        ("scissors", "paper") => "Scissors wins.",
        (_, _) => "Tie.",
    };
}