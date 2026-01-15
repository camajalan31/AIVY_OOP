using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_InheritanceWithConstructor
{
    internal class Program
    {
        //Aivy Camajalan, IT306
        //Title: Simple Inheritance with Constructor
        static void Main(string[] args)
        {
            //Create an instance of the Student Class
            Student student = new Student("Aivy Camajalan", "BSIT");

            student.DisplayStudType();

            //Create an instance if the regular student class
            RegularStudent regularstudent = new RegularStudent("Aivy Camajalan", "BSIT", "IT306");
            regularstudent.SectionEnrolled();//Call method to display regular student info

            //Create an instance of the irregular student class
            IrregularStudent irregularstudent = new IrregularStudent("Mary Joyce Camero", "BSIT", "IT306", "18 units");
            irregularstudent.EnrolledSemUnits();//Call method to display irregular student info

            Console.ReadKey();
        }
    }
}
