using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_RepetitionStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Aivy Camajalan - IT306
            //Problem: Use a for loop structure to print 10 numbers, and print also the sum of all the numbers.

            //declare a variable
            int num;

            //input a number
            Console.WriteLine("Enter a number: ");
            num=Convert.ToInt32(Console.ReadLine());

            //Process
            for (int n = 9 ; n > 0; n--)
            {
                Console.WriteLine(n);
                num+= n;
            }
            //Display the sum of all 10 numbers.
            Console.Write("The sum of all numbers is " + num + ".");
            Console.ReadKey();
        }
    }
}
