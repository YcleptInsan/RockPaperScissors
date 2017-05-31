// using Xunit;
//
// namespace RockPaperScissors
// {
//   public class RockPaperScissorsTests
//   {
//     [Fact]
//     public void Test0_Outcome_Draw()
//     {
//       //arrange
//       string input1 = "rock";
//       string input2 = "rock";
//       RockPaperScissorsOutcome Outcome = new RockPaperScissorsOutcome();
//
//
//       //act
//       string result = Outcome.GetCheckOutcome(input1, input2);
//
//       //assert
//       Assert.Equal("Draw", result);
//     }
//
//     [Fact]
//     public void Test1_Outcome_P1RockP2Scissor()
//     {
//       //arrange
//       string input1 = "rock";
//       string input2 = "scissors";
//       RockPaperScissorsOutcome Outcome = new RockPaperScissorsOutcome();
//
//
//       //act
//       string result = Outcome.GetCheckOutcome(input1, input2);
//
//       //assert
//       Assert.Equal("rock", result);
//     }
//
//     [Fact]
//     public void Test2_Outcome_P1PaperP2Rock()
//     {
//       //arrange
//       string input1 = "paper";
//       string input2 = "rock";
//       RockPaperScissorsOutcome Outcome = new RockPaperScissorsOutcome();
//
//
//       //act
//       string result = Outcome.GetCheckOutcome(input1, input2);
//
//       //assert
//       Assert.Equal("paper", result);
//     }
//     [Fact]
//     public void Test3_Outcome_P1ScissorsP2Paper()
//     {
//       //arrange
//       string input1 = "scissors";
//       string input2 = "paper";
//       RockPaperScissorsOutcome Outcome = new RockPaperScissorsOutcome();
//
//
//       //act
//       string result = Outcome.GetCheckOutcome(input1, input2);
//
//       //assert
//       Assert.Equal("scissors", result);
//     }
//   }
// }
