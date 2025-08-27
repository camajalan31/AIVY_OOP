using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_EncapUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Main:
            Console.Clear();
            Console.WriteLine("\tThis program will ask you about Shoe details.\n\n");
            Console.Write("Brand Name: \t");
            string bName = Console.ReadLine();

            Console.Write("Price: \t\t");
            string bPrice = Console.ReadLine();



            //Instantiate the Shoe Class
            Shoe myShoe = new Shoe();

            myShoe.Brand = bName;
            myShoe.Price = bPrice;

            //Call the Method to display  the Shoe details Information
            myShoe.DisplayShoeDetails();

            //Input another Shoe details
            Console.WriteLine("\n Do you want to input another Shoe details (yes/no)?  ");
            string ans = Console.ReadLine();

            if (ans == "yes")
            {
                goto Main;
            }
            else if (ans == "no")
            {
                return;
            }


            Console.ReadKey();
        }
    }
    
}
