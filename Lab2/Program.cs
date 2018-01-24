using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            string userName = "new";
            bool Exit = false;
            bool oneMoreTime = true;
            char doAgain;

            Console.WriteLine("Hello, welcome to Lab Number 2!");
            System.Threading.Thread.Sleep(1000);

            //begin while loop so that user can exit or start over
            while (Exit == false)
            {
                //get user's name
                Console.Write("Please enter your name: ");
                userName = Console.ReadLine();
                Console.Clear();
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine($"Thanks, {userName}!. Please enter an integer between 1 and 100.");

                //get user's number input and check if integer between 1 and 100
                if (int.TryParse(Console.ReadLine(), out userInput) && userInput > 1 && userInput < 100)
                {
                    oneMoreTime = true;
                    Console.Clear();
                    //run processing and output after input is validated
                    if (userInput % 2 != 0) //odd + userInput printed
                    {
                        Console.WriteLine($"Okay, {userName}, you've entered: {userInput} Odd.");
                    }
                    else if (userInput % 2 == 0 && userInput >= 2 && userInput <= 25) //even btw 2 & 25 incl
                    {
                        Console.WriteLine($"Okay, {userName}, your result is: Even and less than 25.");
                    }
                    else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60) //even btw 26 & 60 incl
                    {
                        Console.WriteLine($"Okay, {userName}, your result is: Even.");
                    }
                    else if (userInput % 2 == 0 && userInput > 60) //even + userInput printed, greater than 60
                    {
                        Console.WriteLine($"Okay, {userName}, your result is: {userInput} Even.");
                    }
                    else if (userInput % 2 != 0 && userInput > 60) //odd + userInput printed, greater than 60
                    {
                        Console.WriteLine($"Okay, {userName}, your result is: {userInput} Odd.");
                    }

                    //prompt to rerun program
                    while (oneMoreTime == true)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Would you like to run again? (Y/N)");
                        //doAgain = Convert.ToChar(Console.ReadLine());

                        if (char.TryParse(Console.ReadLine(), out doAgain))
                        {
                            if (doAgain == 'y' || doAgain == 'Y')
                            {
                                Console.Clear();
                                Console.WriteLine("Here we go!");
                                System.Threading.Thread.Sleep(500);
                                Console.Clear();
                                oneMoreTime = false;
                            }
                            else if (doAgain == 'n' || doAgain == 'N')
                            {
                                Console.Clear();
                                Console.WriteLine("Goodbye! Press the enter key to exit.");
                                oneMoreTime = false;
                                Exit = true;
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Input not understood.");
                                System.Threading.Thread.Sleep(250);
                                Console.Clear();
                            }
                        }

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Oops! Not a recognized input. Let's start over!");
                }
            }
        }    
    }
}
