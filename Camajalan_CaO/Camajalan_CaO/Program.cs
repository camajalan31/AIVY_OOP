using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_CaO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aivy Camajalan_IT306
            //Title: Creating a Class

             //Instantiate object
             Person person1 = new Person();

            //Initialization of fields
            person1.name = "Aivy";
            person1.age = 18;
            person1.gender = "girl";

            //call the method to display information
            person1.Greet();

            Console.ReadLine();
        }
    }
}
