using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj08
{
    public class Dice
    {
        //Create some private variables for the dice
        private int
            dieOne,
            dieTwo;

        //Declare the randomizer
        private Random
               randomNums;

        public Dice()
        {
            //initialize the randmizer
            randomNums = new Random();
        }

        //Create method that will roll the dice that are private
        public void RollDice(ref int dieOne, ref int dieTwo)
        {
            //Create random numbers for the dice variables
            dieOne = randomNums.Next(1, 7);
            dieTwo = randomNums.Next(1, 7);
        }
    }
}
