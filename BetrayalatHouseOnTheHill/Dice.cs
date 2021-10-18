using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetrayalatHouseOnTheHill
{
    class Dice
    {
        public int[] SideValues { get; set; }
        
        public Dice()
        {
            SideValues = new int[]{ 0, 0, 1, 1, 2, 2 };
        }


        public int DiceRoller()
        {
            var rnd = new Random();
            var roll = rnd.Next(0, 6);
            Console.WriteLine($"You rolled a {SideValues[roll]}");
            return SideValues[roll];
        }
    }
}
