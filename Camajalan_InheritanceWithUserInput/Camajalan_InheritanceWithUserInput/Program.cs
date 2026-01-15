using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Camajalan_InheritanceWithUserInput
{
    internal class Program
    {
        //Camajalan, Aivy, IT306
        //Inheritance with User Input
        static void Main(string[] args)
        {
        Main:
            Console.WriteLine("\n\tWhat type of Shoes are you going to buy, Casual or Athletic?");
            Console.Write("\nChoose what type of shoe you want to buy: ");
            string choice = Console.ReadLine();

            // Make a choice what type of shoe they want
            if (choice == "Casual")
            {
                Console.Write("Enter the Brand Name: ");
                string brand = Console.ReadLine();

                Console.Write("Enter the Size: ");
                string size = Console.ReadLine();

                Console.Write("Enter the Color: ");
                string color = Console.ReadLine();

                Console.Write("Enter the Price: ");
                int price = Convert.ToInt32(Console.ReadLine());

                //Instantiate the derived class
                Casual casual = new Casual();

                casual.Brand = brand;
                casual.Size = size;
                casual.Color = color;
                casual.Price = price;
               
                casual.CasualInfo(); //call the method to display casual shoe info
            }
            else if (choice == "Athletic")
            {
                Console.Write("Enter the Brand Name: ");
                string brand = Console.ReadLine();

                Console.Write("Enter the Size: ");
                string size = Console.ReadLine();

                Console.Write("Enter the Color: ");
                string color = Console.ReadLine();

                Console.Write("Enter the Price: ");
                int price = Convert.ToInt32(Console.ReadLine());

                //Instantiate the derived class
                Athletic athletic = new Athletic();

                athletic.Brand = brand;
                athletic.Size = size;
                athletic.Color = color;
                athletic.Price = price;


                athletic.AthleticInfo(); //call the method to display athletic shoe info
            }
            else
            {
                Console.WriteLine("Invalid input!");
                
            }

            //Input another shoe details
            Console.WriteLine("\nDo you want to input another Shoe (yes/no)?  ");
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
