using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            //Initialise variable to be used in loop
            bool valid = false;

            //Instantiate the statistics counter
            Statistics stats = new Statistics();
            //Loop to error handle so that if an invalid input is entered the user can try again without the program closing.
            while (valid == false)
            {
                //Display the menu to the user.
                Console.WriteLine("Do you want to play Sevens Out, Three or More, see your statistics, run a test or quit the program? \nSevens/Three/Stats/Test/Quit: ");
                //Allow the user to navigate the menu, storing their answer and ensuring its uppercase.
                string confirm = Console.ReadLine();
                confirm = confirm.ToUpper();
                //Exception handling, try to carry out the if statements to check if the user inputted a valid character and then throw an error if the input is invalid.
                try
                {
                    //If the users input is y or Y then carry out the test
                    if (confirm == "TEST")
                    {
                        //Constructor to test the dice are correct values and result
                        Testing test = new Testing();
                        test.Test();
                    }
                    //If the users input is n or N then play the game
                    else if (confirm == "SEVENS")
                    {
                        try
                        {
                            SevensOut sevens = new SevensOut();
                            Console.WriteLine($"{sevens.Sevens()}");
                        }
                        catch (Exception) 
                        {
                            Console.WriteLine("Problem with running program: Sevens Out");
                        }
                    }
                    else if (confirm == "THREE")
                    {
                        try
                        {

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid character or symbol, try again.");
                        }
                    }
                    else if (confirm == "STATS")
                    {
                        try
                        {
                            Console.WriteLine($"{stats.SevensStats()}");
                            Console.WriteLine($"{stats.ThreesStats()}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid character or symbol, try again.");
                        }
                    }
                    else if (confirm == "QUIT")
                    {
                        break;
                    }
                    //If neither statement is carried out then throw an error as it is an invalid input
                    else
                    {
                        throw new Exception();
                    }
                }
                //Catch the exception we have previously thrown as a result of an invalid input and display a message alerting the user of the mistake.
                catch (Exception)
                {
                    Console.WriteLine("Invalid character or symbol, try again.");
                }
            }
            //Prevents the application from ending abruptly.
            Console.WriteLine("Program has terminated.");
            Console.ReadKey();
        }
    }
}
