using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //this displays hello world

            Console.WriteLine("Hello, World!");


            //tell the user about the program
            Console.WriteLine("Try to guess the number I am thinking of: ");

            //initialise the number and set its value
            int num = 9;
            // initialise the response
            int i;
            
           

            decimal response = 0M;
            char finished = 'N';
            char anotherGuess;

            do
            {
                //ask the user to enter a number
                Console.WriteLine("Please enter a number between 1 to 10: ");
                response = Convert.ToInt32(Console.ReadLine());

                //get the response

                //check if the number is correct


                //if it's wrong, then say if it's higher or lower than the correct number

                if (response >= 5 && response < 10)
                {

                    if (response >= 5 && response <= 8)
                    {
                        Console.WriteLine("you are nearly there");


                    }
                    else if (response < 5)
                    {
                        Console.WriteLine("you guessed a lower number.");
                    }
                    else
                    {
                        Console.WriteLine("great!! you guessed the right number");
                    }


                }


                else
                {
                    Console.WriteLine("its way too smaller number");
                }

                Console.WriteLine("Do you want to enter another number? (Y/N) ");
                anotherGuess = Convert.ToChar(Console.ReadLine());
                finished = Char.ToUpper(anotherGuess);

            } while (finished != 'N');
        }
    }
} 
           
       
    

