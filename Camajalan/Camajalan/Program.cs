using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person ("Aybi", 18, "Girl"); 

            //call method
            Console.WriteLine ("Personal Information:");
            Console.WriteLine ("Name:"+person1.Name +"\nAge: " + person1.Age+ "\nGender: "  + person1.Gender );

            Console.ReadLine ();
        }
    }
}
