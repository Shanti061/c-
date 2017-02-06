using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nextStar
{
    class Program
    {
        static void Main(string[] args)
        {
            
             
            Console.WriteLine("choose the singer you like, Selena, Rihanna, Taylor");
            string reply =  (Console.ReadLine()).ToLower();


            switch (reply)
            {
                case "selena":
                    Console.WriteLine("Great choice!!");
                     break;
                case "rihanna":
                    Console.WriteLine("Good singer!!");
                    break;
                case "taylor":
                    Console.WriteLine("That's mine favourite too!!");
                    break;
                default:
                    Console.WriteLine("oops");
                    break;
            }

            //to displaye the value of reply--- Console.Writeline(reply);
        }
    }
}
