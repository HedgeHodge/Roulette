using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roulette
{
    class RouletteWheel
    {
        Random rand = new Random();
        int[][] bins = new int[12][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 }, new int[] { 10, 11, 12 }, new int[] { 13, 14, 15 }, new int[] { 16, 17, 18 }, new int[] { 19, 20, 21 }, new int[] { 22, 23, 24 }, new int[] { 25, 26, 27 }, new int[] { 28, 29, 30 }, new int[] { 31, 32, 33 }, new int[] { 34, 35, 36 } };
        int[] reds = new int[18] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

        public void DropBall (Bet myBet)
        {

            // Initialize variables

            int totalScore = 0;
            int filledSlot = rand.Next(36) + 1;
            string evenOdd = filledSlot % 2 == 0 ? "even" : "odd";
            string redBlack = reds.Contains<int>(filledSlot) ? "red" : "black";
            string lowHigh = filledSlot < 19 ? "low" : "high";
            int column = 0;
            int street = 0;
            int thirds = 0;

            Console.WriteLine($"Slot filled: {filledSlot}");

            // Calculate street

            for (int i = 0; i < bins.GetLength(0); i++)
            {
                if (bins[i].Contains<int>(filledSlot))
                {
                    street = i + 1;
                }
            }

            // Calculate column

            for (int i = 0; i < bins.GetLength(0); i++)
            {
                if(bins[i].Contains<int>(filledSlot))
                {
                    column = Array.IndexOf(bins[i], filledSlot) + 1;
                }
            }

            // Calculate thirds position

            if (filledSlot < 13)
            {
                thirds = 1;
            }
            else if(filledSlot > 12 && filledSlot < 25)
            {
                thirds = 2;
            }
            else if(filledSlot > 24)
            {
                thirds = 3;
            }

            // Calculate all bets

            if(myBet.binNum == filledSlot)
            {
                totalScore += 10;
                Console.WriteLine($"bin num checks out");
            }

            if (myBet.evenOrOdd.ToLower() == evenOdd)
            {
                totalScore += 10;
                Console.WriteLine($"evenOrOdd checks out");
            }

            if (myBet.redOrBlack.ToLower() == redBlack)
            {
                totalScore += 10;
                Console.WriteLine($"redOrBlack checks out");
            }

            if (myBet.lowOrHigh.ToLower() == lowHigh)
            {
                totalScore += 10;
                Console.WriteLine($"lowOrHigh checks out");
            }

            if (myBet.thirdsSection == thirds)
            {
                totalScore += 10;
                Console.WriteLine($"thirdsSection checks out");
            }

            if (myBet.column == column)
            {
                totalScore += 10;
                Console.WriteLine($"column checks out");
            }

            if (myBet.street == street)
            {
                totalScore += 10;
                Console.WriteLine($"street checks out");
            }

            string[] doubleRowsBetArr = myBet.doubleRows.Split(" ");
            if(street.ToString() == doubleRowsBetArr[0] || street.ToString() == doubleRowsBetArr[1])
            {
                totalScore += 10;
                Console.WriteLine($"double checks out");
            }


            string[] splitBetArr = myBet.split.Split(" ");
            if (splitBetArr.Contains<string>(filledSlot.ToString()))
            {
                totalScore += 10;
                Console.WriteLine($"split checks out");
            }

            string[] cornerBetArr = myBet.corner.Split(" ");
            if (cornerBetArr.Contains<string>(filledSlot.ToString()));
            {
                totalScore += 10;
                Console.WriteLine($"corner checks out");
            }

            // Write the final bet score

            Console.WriteLine($"The total score is: {totalScore}");
        }
    }
}
