using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_SimpleInheritance
{
    class Student // Base Class      
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
            //Additional property for RegularStudent class
            public string Section { get; set; }

            //Method to display RegularStudent information
            public void SectionEnrolled()
            { 
             Console.WriteLine($"Section: {Section}");
            }
    }        
    class IrregularStudent : Student //Derived Class
    { 
           //Additional property for IrregularStudent class
           public string UnitsEnrolled { get; set; }

            //Method to display IrregularStudent Information
            public void EnrolledSemUnits() 
            { 
             Console.WriteLine($"UnitsEnrolled: {UnitsEnrolled}");
            }
     }
}
