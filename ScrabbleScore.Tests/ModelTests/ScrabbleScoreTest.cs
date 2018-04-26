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
    public void ScrabbleWordQ()
    {
      string _word = "QZuincy";
      //ScrabbleCheck score = new ScrabbleCheck();
      int score = 0;
      foreach(char letter in _word){
        //letter.ToArray();
        //foreach(char letter in word){
          //Console.WriteLine("The letters are:" + letter);
        if(letter.Contains("Q"))
        {
           score++;

        }
        else
        {
          score += 0;
        }
        // else if(_word.Contains("Z"))
        // {
        //   score += 10;
        // //  Console.WriteLine("Second Score:" + score);
        // }
        // else
        // {
        //   score +=1;
        // }

        Console.WriteLine("The word is:"+ letter);
      }
        Console.WriteLine("Score:" + score);
    }
  }
}
