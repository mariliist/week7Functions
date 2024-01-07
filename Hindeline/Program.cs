//Console.WriteLine("Enter your comment:");
//string userInput = Console.ReadLine();

//CountSpaces(userInput);

//static void CountSpaces(string someString)
//{
//    someString = someString.Trim();
//    int wordCounter = 1;

//    foreach (char symbol in someString)
//    {
//        if (char.IsWhiteSpace(symbol))
//        {
//            wordCounter++;
//        }
//    }

//    string word = "word";
//    if (wordCounter > 1)
//    {
//        word = "words";
//    }

//    Console.WriteLine($"Your comment contains {wordCounter} {word}.");
//}

//Console.WriteLine("How many steps have you walked today?");
//int usersSteps = Int32.Parse(Console.ReadLine());

//string result = HealthMonitor(usersSteps);

//Console.WriteLine(result);

//static string  HealthMonitor(int steps)
//{
//    if (steps < 4000)
//    {
//        result "You need to move more.";
//    }
//    else if (steps >= 4000 && steps < 8000)
//    {
//        result "Health goal achieved,";
//    }
//    else
//    {
//        result "Well done!";
//    }
//}

Console.WriteLine("Choose: 1. Fahrenheit to Celsius / 2. Celsius to Fahrenheit");
int choice = Int32.Parse(Console.ReadLine());

if (choice == 1)
{
    Console.Write("Fahrenheit degrees: ");
    double fahrenheit = Double.Parse(Console.ReadLine());
    ConvertToCelsius(fahrenheit);
}
else if (choice == 2)
{
    Console.Write("Celsius degrees: ");
    double celsius = Double.Parse(Console.ReadLine());
    ConvertToFahrenheit(celsius);
}
else
{
    Console.WriteLine("Incorrect");
}
    

    static void ConvertToCelsius(double fahrenheit)
{
    double celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine($"{fahrenheit} Fahrenheit degrees are {celsius} Celsius degrees.");
}

static void ConvertToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9) / 5 + 32;
    Console.WriteLine($"{celsius} Celsius degrees are {fahrenheit} Fahrenheit degrees");
}


//Console.WriteLine("Enter your name:");
//string userName = Console.ReadLine();

//GreetUser(userName);

//static void GreetUser(string someName)
//{
//    Console.WriteLine($"Hello, {someName}");
//}