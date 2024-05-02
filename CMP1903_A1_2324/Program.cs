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
                    //If the user inputs test then it carries out testing.
                    if (confirm == "TEST")
                    {
                        //Constructor to test the dice are correct values and result
                        Testing test = new Testing();
                        test.Test();
                    }
                    //If the users input is sevens then play Sevens Out
                    else if (confirm == "SEVENS")
                    {
                        //Try play the game
                        try
                        {
                            SevensOut sevens = new SevensOut();
                            Console.WriteLine($"{sevens.Sevens()}");
                        }
                        //If there's any problems with the game catch the error and send them back to the menu.
                        catch (Exception) 
                        {
                            Console.WriteLine("Problem with running program: Sevens Out");
                        }
                    }
                    //If the users input is three then play Three or More
                    else if (confirm == "THREE")
                    {
                        //Try play the game
                        try
                        {

                        }
                        //If there's any problems with the game catch the error and send them back to the menu.
                        catch (Exception)
                        {
                            Console.WriteLine("Problem wtih running program: Three or More");
                        }
                    }
                    //If the users input is stats then display game statistics
                    else if (confirm == "STATS")
                    {
                        //Try displaying the stats to the console
                        try
                        {
                            Console.WriteLine($"{stats.SevensStats()}");
                            Console.WriteLine($"{stats.ThreesStats()}");
                        }
                        //Catch any errors with displaying stats
                        catch (Exception)
                        {
                            Console.WriteLine("Problem with displaying game statistics.");
                        }
                    }
                    //If the users input is quit then end the program.
                    else if (confirm == "QUIT")
                    {
                        break;
                    }
                    //If no statement is carried out then throw an error as it is an invalid input
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
            //Prevents the application from ending abruptly and informs the user the program has ended so it can end smoothly.
            Console.WriteLine("Program has terminated.");
            Console.ReadKey();
        }
    }
}
