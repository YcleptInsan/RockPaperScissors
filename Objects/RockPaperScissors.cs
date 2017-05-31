using System.Collections.Generic;
using System;

namespace RockPaperScissors
{
    public class RockPaperScissorsOutcome
    {
      private string _input1;

      public RockPaperScissorsOutcome(string input1)
      {
        _input1 = input1;
      }

      public string GetInput1()
      {
        return _input1;
      }

      public void SetInput(string input1)
      {
        _input1 = input1;
      }

    }
}
