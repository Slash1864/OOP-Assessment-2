using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        //Variable to store sum of dice.
        public int sum = 0;

        //Variable to store player score totals
        public int oneTotal = 0;
        public int twoTotal = 0;

        //Variable to decide player turns.
        public bool playerOneTurn = true;
        public bool playerTwoTurn = false;

        //Variable to declare game end
        public string gameEnd = "\nGame has ended\n";

        //Instantiate five dice to be rolled.
        public Die die1 = new Die();
        public Die die2 = new Die();
        public Die die3 = new Die();
        public Die die4 = new Die();
        public Die die5 = new Die();

    }
    //Declare Sevens Out class which inherits from Game class
    internal class SevensOut : Game
    {
        public string Sevens()
        {
            //Method calling to increase total games statistic.
            Statistics.sevensTotalGames = Statistics.sevensTotalGames + 1;
            //Loop to play all of player 1's turn
            while (playerOneTurn == true)
            {
                //Inform the players it's player 1s turn
                Console.WriteLine("Player 1 Rolls.");

                //Roll the 3 seperate die and then display the number they rolled.
                int numberOne = die1.Roll();
                Console.WriteLine($"Dice One: {numberOne}");

                int numberTwo = die2.Roll();
                Console.WriteLine($"Dice Two: {numberTwo}");

                sum = numberOne + numberTwo;
                if (numberOne == numberTwo)
                {
                    oneTotal = oneTotal + ((numberOne + numberTwo) * 2);
                }
                else if (sum == 7)
                {
                    oneTotal = oneTotal + sum;
                    playerOneTurn = false;
                    playerTwoTurn = true;
                }
                else if (numberOne != numberTwo)
                {
                    oneTotal = oneTotal + sum;
                }

                Console.WriteLine($"Sum: {oneTotal}");
            }
            Console.WriteLine("Player 1 got 7!\nPlayer 2s turn.");
            //Player 2 Rolls
            while (playerTwoTurn == true)
            {
                Console.WriteLine("Player 2 Rolls.");
                //Roll the 3 seperate die and then display the number they rolled.
                int numberOne = die1.Roll();
                Console.WriteLine($"Dice One: {numberOne}");

                int numberTwo = die2.Roll();
                Console.WriteLine($"Dice Two: {numberTwo}");

                sum = numberOne + numberTwo;
                if (numberOne == numberTwo)
                {
                    twoTotal = twoTotal + ((numberOne + numberTwo) * 2);
                }
                else if (sum == 7)
                {
                    twoTotal = twoTotal + sum;
                    playerTwoTurn = false;
                }
                else if (numberOne != numberTwo)
                {
                    twoTotal = twoTotal + sum;
                }

                Console.WriteLine($"Sum: {twoTotal}");
            }

            Console.WriteLine("Player 2 got 7!\nGame Over!\n");
            if (oneTotal > twoTotal)
            {
                Console.WriteLine($"Player One wins with a score of {oneTotal}!");
                Statistics.sevensPlayerOneWins = Statistics.sevensPlayerOneWins + 1;
                if (oneTotal > Statistics.sevensHighestScore)
                    {
                        Statistics.sevensHighestScore = oneTotal;
                    }
            }
            else if (twoTotal > oneTotal) 
            {
                Console.WriteLine($"Player Two wins with {twoTotal} score!");
                Statistics.sevensPlayerTwoWins = Statistics.sevensPlayerTwoWins + 1;
                if (twoTotal > Statistics.sevensHighestScore)
                {
                Statistics.sevensHighestScore = twoTotal;
                }
            }
            else if (oneTotal == twoTotal)
            {
                Console.WriteLine($"It's a draw with both players getting {oneTotal}");
            }
            return gameEnd;
        }
    }
    internal class ThreesorMore : Game
    {
        public string Threes()
        {
            return null;
        }
    }
}
