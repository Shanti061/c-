using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers to get their average value. ");
           int[] input = new int[5];
           
            int average;
           int total= 0;
            for (int i = 0; i < input.Length; i++) {
                Console.WriteLine("Enter another value: ");
                input[i] = Convert.ToInt32(Console.ReadLine());
                
                total += input[i];
                
            }
            average = (total / 5);
            Console.WriteLine("average: " + average);
        }
    }
}
