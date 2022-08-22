using System;


Console.WriteLine("Guess The secret number?");
string answer = Console.ReadLine(); //reads the user input
int ParsedAnswer = int.Parse(answer); //parsing user answer to integer
Console.WriteLine($"Your guess is {ParsedAnswer}");
