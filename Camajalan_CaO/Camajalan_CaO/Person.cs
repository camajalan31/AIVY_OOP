using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_CaO
{
    internal class Person
    {
        //Class Members
        public string name;
        public int age;
        public string gender;

        //Method to Display the fields
        public void Greet()
        {
            Console.WriteLine("Good Day everyone, I'm " + name + " " + age + "years old. I'm a " + gender + ".");
        }
    }
}
