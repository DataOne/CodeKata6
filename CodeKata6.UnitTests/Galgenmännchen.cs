using System;
using Xunit;

namespace Galgenmännchen;

public class GalgenmännchenTest
{
    [Fact]
    public void ConstructorShouldThrowExceptionIfWordIsEmpty()
    {
        Assert.Throws<Exception>(() => new Galgenmännchen(""));
    }

    [Fact]
    public void RateBuchstabeShouldReturnStringWithBuchstabeIfWordContainsBuchstabe()
    {
        var unitUnderTest = new Galgenmännchen("Test");
        Assert.Equal("-e--", unitUnderTest.RateBuchstabe('e'));
    }

    [Fact]
    public void RateBuchstabeShouldReturnStringWithBuchstabeIfWordContainsCaseInsensitiveBuchstabe()
    {
        var unitUnderTest = new Galgenmännchen("Test");
        Assert.Equal("-e--", unitUnderTest.RateBuchstabe('E'));
    }

    [Fact]
    public void RateBuchstabeShouldReturnStringWithoutBuchstabeIfWordDoesNotContainBuchstabe()
    {
        var unitUnderTest = new Galgenmännchen("Test");
        Assert.Equal("----", unitUnderTest.RateBuchstabe('x'));
    }

    [Fact]
    public void RateEqualBuchstabeTwiceShouldReturnStringWithBuchstabeIfWordContainsBuchstabe()
    {
        var unitUnderTest = new Galgenmännchen("Test");
        Assert.Equal("-e--", unitUnderTest.RateBuchstabe('e'));
        Assert.Equal("-e--", unitUnderTest.RateBuchstabe('e'));
    }

    [Fact]
    public void RateBuchstabeShouldReturnStringWithBuchstabeIfFirstGuessContainsBuchstabeButSecondDoesnt()
    {
        var unitUnderTest = new Galgenmännchen("Test");
        Assert.Equal("-e--", unitUnderTest.RateBuchstabe('e'));
        Assert.Equal("-e--", unitUnderTest.RateBuchstabe('x'));
    }

    [Fact]
    public void RateBuchstabeShouldReturnStringWithBuchstabeIfFirstGuessDoesntContainsBuchstabeButSecondDoes()
    {
        var unitUnderTest = new Galgenmännchen("Test");
        Assert.Equal("----", unitUnderTest.RateBuchstabe('x'));
        Assert.Equal("-e--", unitUnderTest.RateBuchstabe('e'));
    }

    [Fact]
    public void RateBuchstabeShouldReturnStringWithCaseSensitiveBuchstabeIfWordContainsCaseSensitiveBuchstabe()
    {
        var unitUnderTest = new Galgenmännchen("Tes");
        Assert.Equal("T--", unitUnderTest.RateBuchstabe('T'));
    }

    [Fact]
    public void RateBuchstabeShouldReturnStringWithCaseSensitiveBuchstabeIfWordContainsCaseInsensitiveBuchstabe()
    {
        var unitUnderTest = new Galgenmännchen("Tes");
        Assert.Equal("T--", unitUnderTest.RateBuchstabe('t'));
    }

    [Fact]
    public void RateBuchstabeShouldReturnStringWithBuchstabenIfWordContainsBuchstabeMultipleTimes()
    {
        var unitUnderTest = new Galgenmännchen("Test");
        Assert.Equal("T--t", unitUnderTest.RateBuchstabe('t'));
    }
}