using System.Collections.Generic;
using System;
using System.Linq;

namespace ScrabbleScore.Models
{
  public class ScrabbleCheck
  {
    private string _word;
    private int _score = 0;
    public ScrabbleCheck(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }

    public int GetScore()
    {
      return _score;
    }

    public int CheckScrabble()
    {
      foreach(char letter in _word.ToUpper())
      {
        if(letter == 'Q' || letter =='Z')
        {
           _score+= 10;
        }
        else if(letter == 'J' || letter == 'X')
        {
          _score += 8;
        }
        else if(letter == 'K')
        {
          _score += 5;
        }
        else if(letter == 'F'|| letter == 'H' || letter == 'V'|| letter == 'W'|| letter == 'Y')
        {
          _score += 4;
        }
        else if(letter == 'B'|| letter == 'C'|| letter == 'M'|| letter == 'P')
        {
          _score += 3;
        }
        else if(letter == 'D'|| letter == 'G')
        {
          _score += 2;
        }
        else
        {
          _score += 1;
        }
      }
      return _score;
    }
  }
}
