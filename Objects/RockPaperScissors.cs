using System.Collections.Generic;
using System;

namespace RockPaperScissors
{
  public class RockPaperScissorsOutcome
  {
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
        return "Nick";
      }

    }

  }
}
