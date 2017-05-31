using Xunit;

namespace RockPaperScissors
{
  public class RockPaperScissorsTests
  {
    [Fact]
    public void Test1_Outcome_Check()
    {
      //arrange
      RockPaperScissorsOutcome Outcome = new RockPaperScissorsOutcome("rock");

      //act
      // string result = Outcome.Check(input1);

      //assert
      Assert.Equal("rock", Outcome.GetInput1());
    }
  }
}
