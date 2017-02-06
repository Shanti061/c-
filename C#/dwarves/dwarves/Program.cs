using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarves
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            int i;
            string dinner;

            for (i = 0; i < sevenDwarves.Length; i++)
            {
                
                    Console.WriteLine(sevenDwarves[i] + "  what do you want for dinner?");
                    dinner = Console.ReadLine();
                
                    Console.WriteLine("Your " + dinner + " is ready  " + sevenDwarves[i]);
            }

            foreach (string j in sevenDwarves)
            {
                Console.WriteLine("and your drink is ready " + j);

            }
        }
    }
}


