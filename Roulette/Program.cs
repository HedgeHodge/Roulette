using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip: Multiple values must be separated by a single space\n");
            Bet myBet = new Bet();
            RouletteWheel myRoulette = new RouletteWheel();
            myRoulette.DropBall(myBet);
        }
    }
}
