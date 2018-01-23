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

            //begin while loop so that user can exit or start over
            while (Exit == false)
            {
                //intro and get user's name
                Console.WriteLine("Hello, welcome to Lab Number 2!");
                System.Threading.Thread.Sleep(1000);

                Console.Write("Please enter your name: ");
                userName = Console.ReadLine();
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine($"Thanks, {userName}!. Please enter an integer between 1 and 100.");

                //get user's number input and check if integer between 1 and 100
                if (int.TryParse(Console.ReadLine(), out userInput) && userInput > 1 && userInput < 100)
                {
                    //run processing and output after input is validated
                    if (userInput % 2 != 0) //odd + userInput printed
                    {
                        Console.WriteLine($"Okay, {userName}, you've entered: {userInput} Odd.");
                        Console.Read();
                    }
                    else if (userInput % 2 == 0 && userInput >= 2 && userInput <= 25) //even btw 2 & 25 incl
                    {
                        Console.WriteLine($"Okay, {userName}, your result is: Even and less than 25.");
                        Console.Read();
                    }
                    else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60) //even btw 26 & 60 incl
                    {
                        Console.WriteLine($"Okay, {userName}, your result is: Even.");
                        Console.Read();
                    }
                    else if (userInput % 2 == 0 && userInput > 60) //even + userInput printed, greater than 60
                    {
                        Console.WriteLine($"Okay, {userName}, your result is: {userInput} Even.");
                        Console.Read();
                    }
                    else if (userInput % 2 != 0 && userInput > 60) //odd + userInput printed, greater than 60
                    {
                        Console.WriteLine($"Okay, {userName}, your result is: {userInput} Odd.");
                        Console.Read();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer between 1 and 100");
                }
            }
        }    
    }
}
