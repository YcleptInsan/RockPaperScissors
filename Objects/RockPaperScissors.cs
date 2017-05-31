using System.Collections.Generic;
using System;

namespace RockPaperScissors
{
  public class RockPaperScissorsOutcome
  {
    private string _input1;
    private string _input2;
    private string _winner;

    public RockPaperScissorsOutcome(string input1, string input2)
    {
      _input1 = input1;
      _input2 = input2;
    }
    public string GetInput1()
    {
      return _input1;
    }
    public void SetInput1(string input1)
    {
     _input1 = input1;
    }
    public string GetInput2()
    {
      return _input2;
    }
    public void SetInput2(string input2)
    {
      _input2 = input2;
    }

    public string GetWinner()
    {
      return _winner;
    }
    public void SetWinner(string winner)
    {
      _winner = winner;
    }

    public string  GetCheckOutcome(string input1, string input2)
    {
      if(input1 == "rock"  && input2 == "rock")
      {
        return "Draw";
      }
      else if(input1 == "rock" && input2 == "scissors")
      {
        return (input1 + " Wins");
      }
      else if(input1 == "paper" && input2 == "rock")
      {
        return (input1 + " Wins");
      }
      else if(input1 == "scissors" && input2 == "paper")
      {
        return (input1 + " Wins");
      }
      else
      {
        return (input2 + " Wins");
      }
    }
  }
}
