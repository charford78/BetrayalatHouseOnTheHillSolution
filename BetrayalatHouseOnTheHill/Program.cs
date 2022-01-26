using System;

namespace BetrayalatHouseOnTheHill
{
    class Program
    {
        static void Main(string[] args)
        {
            var dice = new Dice();

            Console.WriteLine("Please enter the number of dice you must roll.  You cannot enter more than 8.");
            var dicenum = Console.ReadLine();
            var dnum = Convert.ToInt32(dicenum);

            //public void DiceEnter()
            //{
            //    Console.WriteLine("Please enter the number of dice you must roll.  You cannot enter more than 8.");
            //    dicenum = Console.ReadLine();
            //}

            //DiceEnter();

            while(dnum !> 0 && dnum !<= 8)
            {
                if(Int32.TryParse(dicenum, out int num) && num > 0 && num <= 8)
                {
                    dice.DiceRoller(num);
                } else
                {
                    Console.WriteLine("You must enter a number from 1 to 8!  Try Again.");
                }
            }
        }
    }
}
