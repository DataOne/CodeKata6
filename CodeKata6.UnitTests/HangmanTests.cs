using Xunit;

namespace CodeKata6.UnitTests;

public class HangmanTests
{
  [Fact]
  public void RateBuchstabeFindsFirstChar()
  {
    var testHangman = new Galgenmännchen("Test");
    var result = testHangman.RateBuchstabe('t');
    Assert.Equal("T--t", result);
    result = testHangman.RateBuchstabe('s');
    Assert.Equal("T-st", result);
    result = testHangman.RateBuchstabe('e');
    Assert.Equal("Test", result);
  }

  [Fact]
  public void RateBuchstabeDoesNotFindWrongCharacter()
  {
    var testHangman = new Galgenmännchen("Test");
    var result = testHangman.RateBuchstabe('x');
    Assert.Equal("----", result);
  }

  [Theory]
  [InlineData("")]
  [InlineData("a")]
  [InlineData("Test")]
  [InlineData("Erdbeerkuchen")]
  [InlineData("Currywurstbudenverkäufergehilfe")]
  public void RateBuchstabeResultsSameLengthAsSearchedWord(string searchedWord)
  {
    var testHangman = new Galgenmännchen(searchedWord);
    var result = testHangman.RateBuchstabe('x');
    Assert.Equal(searchedWord.Length, result.Length);
  }
}
