using System;
using BowlingGame;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace BDD_Demo.SpecFlowtests
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
        
        [When(@"I roll a (.*)")]
        public void WhenIRollA(int p0)
        {
            Game.Roll(p0);
        }
        
        [Then(@"The score should be (.*)")]
        public void ThenTheScoreShouldBe(int p0)
        {
            Game.Score().Should().Be(p0);
        }
    }
}
