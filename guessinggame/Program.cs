using System;

int SecretNumber = 36;
bool isAnswerCorrect = false;
Guesses();

void Guesses()
{
    Console.WriteLine("Guess The secret number?");
    string answer = Console.ReadLine(); //reads the user input
    int ParsedAnswer = int.Parse(answer); //parsing user answer to integer
    GuessEqualToSecretNumber(ParsedAnswer);
    int NumofGuesses = 0;

    while (isAnswerCorrect == false && NumofGuesses < 3)
    {
        Console.WriteLine("Guess The secret number?");
        answer = Console.ReadLine(); //reads the user input
        ParsedAnswer = int.Parse(answer);
        GuessEqualToSecretNumber(ParsedAnswer);
        NumofGuesses += 1;

    }
}
void GuessEqualToSecretNumber(int answer)
{
    if (answer == SecretNumber)
    {
        Console.WriteLine($"Your guess is correct");
        isAnswerCorrect = true;
    }
    else
    {
        Console.WriteLine("Try again");
    }
}
