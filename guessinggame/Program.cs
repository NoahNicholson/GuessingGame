using System;

int SecretNumber = 36;

CompareToNumber();

void CompareToNumber()
{
    Console.WriteLine("Guess The secret number?");
    string answer = Console.ReadLine(); //reads the user input
    int ParsedAnswer = int.Parse(answer); //parsing user answer to integer

    while (String.IsNullOrWhiteSpace(answer))
    {
        Console.WriteLine("Guess The secret number?");
        answer = Console.ReadLine(); //reads the user input
        ParsedAnswer = int.Parse(answer);
    }

    if (ParsedAnswer == SecretNumber)
    {
        Console.WriteLine($"Your guess is correct");
    }
}