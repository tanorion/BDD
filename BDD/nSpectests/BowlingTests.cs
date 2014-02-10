﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingGame;
using FluentAssertions;

namespace BDD.nSpectests
{
    public class BowlingTests : NSpec.nspec
    {
        public void given_i_have_started_a_new_game()
        {
            Game game = null;

            before = () => game = new Game();

            context["And i roll a 5"] = () =>
                    {
                        act = () => game.Roll(5);
                        context["And i roll a 5"] = () =>
                        {
                            act = () => game.Roll(5);
                            context["And i roll a 5"] = () =>
                            {
                                act = () => game.Roll(5);
                                it["My score should now be 20"] = () => game.Score().Should().Be(20);

                            };
                        };                    
                    };
        }
    }
}
