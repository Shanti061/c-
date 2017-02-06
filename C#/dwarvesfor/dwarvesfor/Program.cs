using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarvesArray.snl
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            int i;
            for (i = 0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine(sevenDwarves[i] + "  your dinner is ready");
            }

            foreach (string j in sevenDwarves)
            {
                Console.WriteLine("and your drink is ready " + j);

            }
        }
    }
}
