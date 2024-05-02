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
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        public int sum = 0;

        public bool playerOne = true;
        public bool playerTwo = false;

        public int oneTotal = 0;
        public int twoTotal = 0;

        public bool playerOneTurn = true;
        public bool playerTwoTurn = false;

        public string gameEnd = "\nGame has ended\n";

        //Instantiate two dice to be rolled.
        public Die die1 = new Die();
        public Die die2 = new Die();
        public Die die3 = new Die();
        public Die die4 = new Die();
        public Die die5 = new Die();
        //Methods
        /*
        public int Build()
        {
            
            //Object instantiation to create 3 seperate die objects.
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            //Roll the 3 seperate die and then display the number they rolled.
            int numberOne = die1.Roll();
            Console.WriteLine($"Dice One: {numberOne}");

            int numberTwo = die2.Roll();
            Console.WriteLine($"Dice Two: {numberTwo}");

            int numberThree = die3.Roll();
            Console.WriteLine($"Dice Three: {numberThree}");

            //Add all of the dice rolls up and then return the value to be used in Program().
            sum = numberOne + numberTwo + numberThree;

            return sum;

            //Proof of encapsulation being used as this line returns an error
            //This is because _number cannot be modified outside the Die class.
            //_number = 0;
            */
        //}
    }
    internal class SevensOut : Game
    {
        public string Sevens()
        {
            Statistics.sevensTotalGames = Statistics.sevensTotalGames + 1;
            //Player One Rolls
            while (playerOneTurn == true)
            {
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
