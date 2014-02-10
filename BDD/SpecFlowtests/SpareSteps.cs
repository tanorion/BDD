using System;
using BowlingGame;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace BDD.SpecFlowtests
{
    [Binding]
    public class SpareSteps
    {
        public Game Game { get; set; }
        public int Score { get; set; }

        [Given(@"A new bowling game")]
        public void GivenANewBowlingGame()
        {
            Game=new Game();
        }
        
        [Given(@"I roll a (.*)")]
        public void GivenIRollA(int p0)
        {
            Game.Roll(p0);
        }
        
        [When(@"I get my score")]
        public void WhenIGetMyScore()
        {
            Score=Game.Score();
        }
        
        [Then(@"The score should be (.*)")]
        public void ThenTheScoreShouldBe(int p0)
        {
            Score.Should().Be(p0);
        }
    }
}
