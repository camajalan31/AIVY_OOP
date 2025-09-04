using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_Inheritance
{
    internal class Student
    {
        public string Name { get; set; }
        public string Program { get; set; }

        //Method to display student information
        public void BasicInfo()
        {
            Console.WriteLine("\n -----Student Information-----\n");
            Console.WriteLine($"Name: {Name} \nProgram:  {Program}");
        }
    }

    class RegularStudent : Student //Derived Class
    {
        //Additional property for regstud class
        public string Section { get; set; }

        //Method to display RegularStudent information
        public void SectionEnrolled()
        {
            Console.WriteLine($"Section: {Section}");
        }
    }

    class IrregularStudent : Student //Derived Class
    {
        //Additional property for irregstud class
        public string UnitsEnrolled { get; set; }

        //Method to display IrregularStrudent Information
        public void EnrolledSemUnits()
        {
            Console.WriteLine($"UnitsEnrolled: {UnitsEnrolled}");
        }
    }
}
