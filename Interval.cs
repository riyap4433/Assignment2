using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taking the user input for the real number and storing it in the varible x
            Console.WriteLine("Enter the real number:");
            int x = int.Parse(Console.ReadLine());

            //Declaring and initializing the intervals
            double[] interval1 = { 2, 3 };
            double[] interval2 = { 0, 1 };
            double[] interval3 = { -10, -2 };


        
            // Using conditional statements to test the given condition and printing the output
            if ((x >= interval1[0] && x < interval1[1]) ||
                (x >= interval2[0] && x <= interval2[1]) ||
                (x >= interval3[0] && x <= interval3[1]))
            {
                Console.WriteLine("x belongs to I");
            }
            else
            {
                Console.WriteLine("x does not belong to I");
            }
        }
    }
}
