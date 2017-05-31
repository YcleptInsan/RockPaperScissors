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
      Get["/input1"] = _ => {
      RockPaperScissorsOutcome Outcome = new RockPaperScissorsOutcome();
        string input1 = Request.Query["input1"];
        return View["result.cshtml", input1];
      };
      Get["/input2"] = _ => {
      RockPaperScissorsOutcome Outcome = new RockPaperScissorsOutcome();
        string input2 = Request.Query["input2"];
        return View["result.cshtml", outcome];
      };
    }
  }
}
