using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan
{
    internal class Person
    {
        public string Name, Gender;
        public int Age;
        
        public Person(string Name1, int Age1, string Gender1) 
        {
            Name = Name1;
            Age= Age1;
            Gender =Gender1;    

        }
    }
}
