using System;
using System.Collections.Generic;
using ScrabbleScorer.Models;

namespace ScrabbleScorer
{
  class Program
  {
    static void Main()
    {
      try
      {
        Console.WriteLine("Enter a word to get its Scrabble score:");
        string input = Console.ReadLine();
        Scorer newScorer = new Scorer();
        int score = newScorer.GetScore(input);
        Console.WriteLine($"The score for your word {input} is {score}");
      }
      catch (Exception exceptionInstance)
      {
        Console.WriteLine("Message = {0}", exceptionInstance.Message);
        Console.WriteLine("Please enter a word only containing letters");
        Main();
      }
    }
  }
}