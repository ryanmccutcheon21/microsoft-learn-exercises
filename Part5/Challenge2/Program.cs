// domain: contoso.com
// username = first 2 characters of employee's first name, followed by their full last name

// create a method that will display the email address of internal and external employees. The method should include an optional parameter for the domain name of external employees.

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
// string internalDomain = "contoso.com";

// DisplayEmail(corporate, internalDomain);
DisplayEmail(corporate);
DisplayEmail(external, externalDomain);

void DisplayEmail(string[,] employees, string domain = "contoso.com")
{
    for (int i = 0; i < employees.GetLength(0); i++)
    {
        // display internal email addresses
        string username = employees[i, 0].Substring(0, 2).ToLower() + employees[i, 1].ToLower();
        string email = username + domain;
        Console.WriteLine(email);
    }
}




// Make dice game
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

bool ShouldPlay()
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget()
{
    return random.Next(1, 6);
}

int RollDice()
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    return "You lose!";
}