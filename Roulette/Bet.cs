using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Roulette
{
    class Bet
    {
        public int binNum { get; private set; }
        public string evenOrOdd { get; private set; }
        public string redOrBlack { get; private set; }
        public string lowOrHigh { get; private set; }
        public int thirdsSection { get; private set; }
        public int column { get; private set; }
        public int street { get; private set; }
        public string doubleRows { get; private set; }
        public string split { get; private set; }
        public string corner { get; private set; }

        public Bet()
        {
            Console.WriteLine("Enter a bin number 1-36");
            binNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Do you think it will be even or odd?");
            evenOrOdd = Regex.Replace(Console.ReadLine(), @"\s", "").ToLower();

            Console.WriteLine("Do you think it will be red or black?");
            redOrBlack = Regex.Replace(Console.ReadLine(), @"\s", "").ToLower();

            Console.WriteLine("Do you think it will be low (1-18) or high (19-36)?");
            lowOrHigh = Regex.Replace(Console.ReadLine(), @"\s", "").ToLower();

            Console.WriteLine("Enter the thirds section number\n(1 for 1-12, 2 for 13-24, 3 for 25-36)");
            thirdsSection = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of the column you think it will be in");
            column = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number for the street it will be (1-12)");
            street = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter two contigious numbers to represent the two rows you predict it will land in");
            doubleRows = Console.ReadLine();

            Console.WriteLine("Which two contigious numbers do you think it will land on?");
            split = Console.ReadLine();

            Console.WriteLine("Which intersection will it land on? (1 2 4 5)");
            corner = Console.ReadLine();
            
        }
    }
}
