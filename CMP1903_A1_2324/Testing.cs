using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        private int number = 0;
        private bool end = false;

        //Method
        //The end of the test is then displayed to the user.
        public void Test()
        {
            //Error exception to catch the error that is created if the dice rolls fall out of bounds.
            try
            {
                //Test method which generates a single die which is tested to be between 1 and 6 inclusive.
                Die Dice = new Die();
                number = Dice.Roll();
                Debug.Assert(number >= 1 && number <= 6);
                Console.WriteLine($"Dice Roll: {number}");
                Console.WriteLine("Dice roll is between 1 and 6.\n");

                //Generates a whole game which tests the sum of the 2 is between 2 and 12 inclusive.
                SevensOut sevens = new SevensOut();
                number = sevens.die1.Roll() + sevens.die2.Roll();
                Debug.Assert(number >= 2 && number <= 12);
                Console.WriteLine($"Dice Sum: {number}");
                Console.WriteLine("Dice sum is between 2 and 12.\n");
                //While loop to constantly test if a total  of 7 has been summed.
                while (end == false)
                {
                    //Method calling to roll 2 dice and store them in a variable
                    number = sevens.die1.Roll() + sevens.die2.Roll();
                    Console.WriteLine("Checking if sum is 7.");
                    Console.WriteLine($"Sum: {number}");
                    //Check if the sum is 7
                    if (number == 7)
                    {
                        //break the loop
                        end = true;
                    }
                }
                //Alert the user the test has passed.
                Console.WriteLine("A total of 7 is detected.\n");
                
            }
            //Catch the error
            catch (Exception)
            {
                Console.WriteLine("The test has been failed");
            }
            //Output this message no matter if there was or wasn't an error.
            finally
            {
                Console.WriteLine("Test Complete\n");
            }
        }
    }
}
