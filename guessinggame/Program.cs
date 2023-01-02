using System;
Random r = new Random();
int SecretNumber = r.Next(1, 101);
bool IsAnswerCorrect = false;
int NumofGuesses = 0;
Guesses();

void Guesses()
{
    Console.WriteLine("Guess The secret number?");
    string answer = Console.ReadLine(); //reads the user input
    int ParsedAnswer = int.Parse(answer); //parsing user answer to integer
    GuessEqualToSecretNumber(ParsedAnswer);


    while (IsAnswerCorrect == false && NumofGuesses < 4)
    {
        Console.WriteLine("Guess The secret number?");
        answer = Console.ReadLine(); //reads the user input
        ParsedAnswer = int.Parse(answer);
        GuessEqualToSecretNumber(ParsedAnswer);


    }
}
void GuessEqualToSecretNumber(int answer)
{
    NumofGuesses += 1;
    if (answer == SecretNumber)
    {
        Console.WriteLine($"Your guess is correct");
        IsAnswerCorrect = true;
    }
    else
    {
        Console.WriteLine($"Incorrect. You have have guessed {NumofGuesses} out of 4");
    }
}
