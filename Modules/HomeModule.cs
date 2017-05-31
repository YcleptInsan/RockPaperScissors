using Nancy;
using System;
using System.Collections.Generic;


namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/play"] = _ => {
        RockPaperScissorsOutcome Outcome = new RockPaperScissorsOutcome(Request.Form["input1"], Request.Form["input2"]);
        string input1 = Outcome.GetInput1();
        Console.WriteLine(input1);
        string input2 =  Outcome.GetInput2();
        Console.WriteLine(input2);
        string winner = Outcome.GetCheckOutcome(input1, input2);
        Console.WriteLine(winner);
        return View["result.cshtml", winner];
      };
    }
  }
}
