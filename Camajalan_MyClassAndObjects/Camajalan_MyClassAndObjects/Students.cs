using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_MyClassAndObjects
{
    internal class Students
    {
        //Class Atttributes
        public string name;
        public string section;
        public string course;

        //Method to display Information
        public void DisplayInfo()
        {
            Console.Write("Hi I'm " + name + " from section " + section + " currently taking " + course + " 2nd year level.");
        }
    }
}
