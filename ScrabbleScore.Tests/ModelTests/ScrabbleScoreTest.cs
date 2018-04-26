using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Linq;
//using ScrabbleScore.Models;


namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleScoreTests
  {
    [TestMethod]
    public void ScrabbleWord_CheckQ_Z()
    {
      string _word = "Quincy";
      string new_word = _word.ToUpper();
      int score = 0;
      foreach(char letter in new_word)
      {
        if(letter == 'Q' || letter =='Z')
        {
           score+= 10;

        }
        else
        {

        }
        Console.WriteLine("The letter is:"+ letter);
      }
        Console.WriteLine("Score:" + score);
    }
    [TestMethod]
    public void ScrabbleWord_CheckForJandX()
    {
      string _word = "jack";
      string new_word = _word.ToUpper();
      int score = 0;
      foreach(char letter in new_word)
      {
        if(letter == 'J' || letter =='X')
        {
          score +=8;
        }
        else
        {

        }
        Console.WriteLine("The letter is:"+ letter);
      }
        Console.WriteLine("Score:" + score);
    }
  }
}
