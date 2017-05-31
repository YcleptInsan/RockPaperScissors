using Xunit;

namespace RockPaperScissors
{
  public class RockPaperScissorsTests
  {
    // [Fact]
    // public void Test1_Outcome_Check()
    // {
    //   //arrange
    //   RockPaperScissorsOutcome Outcome = new RockPaperScissorsOutcome("rock");
    //
    //   //act
    //   //assert
    //   Assert.Equal("rock", Outcome.GetInput1());
    // }
    //
    // [Fact]
    // public void Test2_Outcome_Draw()
    // {
    //   //arrange
    //   string input1 = "rock";
    //   string input2 = "rock";
    //   RockPaperScissorsOutcome Outcome = new RockPaperScissorsOutcome();
    //
    //
    //   //act
    //   string result = Outcome.GetCheckOutcome(input1, input2);
    //
    //   //assert
    //   Assert.Equal("Draw", result);
    // }

    [Fact]
    public void Test2_Outcome_P1RockP2Scissor()
    {
      //arrange
      string input1 = "rock";
      string input2 = "scissors";
      RockPaperScissorsOutcome Outcome = new RockPaperScissorsOutcome();


      //act
      string result = Outcome.GetCheckOutcome(input1, input2);

      //assert
      Assert.Equal("rock", result);
    }
  }
}
