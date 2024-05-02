using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Statistics
    {
        public static int sevensHighestScore = 0;
        public static int sevensPlayerOneWins = 0;
        public static int sevensPlayerTwoWins = 0;
        public static int sevensTotalGames = 0;

        public static int threesHighestScore = 0;
        public static int threesPlayerOneWins = 0;
        public static int threesPlayerTwoWins = 0;
        public static int threesTotalGames = 0;

        public string SevensStats()
        {
            Console.WriteLine($"\nSevens Out");
            Console.WriteLine($"Highest Sevens Score: {sevensHighestScore}");
            Console.WriteLine($"Player One, Sevens Out Wins: {sevensPlayerOneWins}");
            Console.WriteLine($"Player Two, Sevens Out Wins: {sevensPlayerTwoWins}");
            Console.WriteLine($"Sevens Out Games Played: {sevensTotalGames}");
            return null;
        }
        public string ThreesStats()
        {
            Console.WriteLine($"\nThree or More");
            Console.WriteLine($"Highest Three or More Score: {threesHighestScore}");
            Console.WriteLine($"Player One, Three or More Wins: {threesPlayerOneWins}");
            Console.WriteLine($"Player Two,Three or More Wins: {threesPlayerTwoWins}");
            Console.WriteLine($"Three or More Ganes Played: {threesTotalGames}\n");
            return null;
        }
    }
}
