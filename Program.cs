using System;
using System.Collections.Generic;

Console.WriteLine($"difficulty level? 1 -easy, 2 - medium, 3 -hard, 4 -cheater");
var difficulty = int.Parse(Console.ReadLine());
int numberOfGuesses = new int[] { 8, 6, 4, 1}[difficulty - 1];

int secretNumberValue = new Random().Next(1,101);
number secretNumber = new number (secretNumberValue);
  while (difficulty == 4 || numberOfGuesses > 0){
      string guessesLeft = difficulty == 4 ? "INFINITE!" : numberOfGuesses.ToString();
       Console.WriteLine("Guess the secret number!");
    string guess = Console.ReadLine();
    Console.Write($"Your Guess (Guesses Left: {guessesLeft}): ");
if(secretNumberValue == Int32.Parse(guess)){

    Console.WriteLine("Correct!");
    break;
}
if (numberOfGuesses==0){
Console.WriteLine($"Out of guesses! The answer was {secretNumberValue}");
}
else if(secretNumberValue > Int32.Parse(guess))  
{
    Console.WriteLine("Too Low!");
    Console.WriteLine($"Incorrect! You Have {guessesLeft} guesses left");
} else {
    Console.WriteLine("Too High!");
    Console.WriteLine($"Incorrect! You Have {guessesLeft} guesses left");
    
}
    if(numberOfGuesses==0){break;}
else{continue;};
}


public class number
{
    
    public int Value { get; set; }

    public number(int value)
    {
        this.Value = value;
    }
}