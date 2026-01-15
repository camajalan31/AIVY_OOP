using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_ControlFlowStructures
{
    internal class Program
    {
        static void Main(string[] args)

        //Aivy Camajalan IT306
        //Problem: Check if a number entered by the user is between a certain range of numbers (inclusive).
        {

            // users input a number
            int LowRange = 50;
            Console.WriteLine("The range is between 1-50 only. Enter a number and it will identify if its range of number or not.");
           

            // enter a number to identify if it is between the range or not+
            Console.Write("Enter a num: ");
            LowRange = Convert.ToInt32(Console.ReadLine());

            //setting the range of a number and displaying the output whether it is  between the range or not.
            if ( LowRange <= 50 ) 
            {
                Console.WriteLine("The number is between the range");
            }
            else
            {
                Console.WriteLine("The number is not between the range");

            }

            Console.ReadKey();
        }
    }
}
