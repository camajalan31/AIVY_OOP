using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_SimpleInheritance
{
    internal class Program
    {
        //Aivy Camajalan, IT306
        //Title:Simple Inheritance
        static void Main(string[] args)
        {         
            //Create an instance of the regular student class
            RegularStudent regularStudent = new RegularStudent 
            {
                Name = "Aivy Camajalan",
                Program = "BSIT",
                Section = "IT306"
            };
            regularStudent.BasicInfo();// call inherited method to display student information
            regularStudent.SectionEnrolled(); //call method to display regular students details

            //Create an instance of the irregular student class
            IrregularStudent irregularStudent = new IrregularStudent
            {
                Name = "Mary Joyce Camero",
                Program = "BSIT",
                UnitsEnrolled = "18 units"
            };
            irregularStudent.BasicInfo();
            irregularStudent.EnrolledSemUnits();//call method to display irregular student

            Console.ReadKey();  

        }
    }
}
