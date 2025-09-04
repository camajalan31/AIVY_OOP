using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_Inheritance
{
    internal class Program
    {
        //Aivy Camajalan, IT306
        //Title:Simple Inheritance
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Aivy Camajalan",
                Program = "BSIT"
            };
            //student.BasicInfo(); // call method to display student info

            RegularStudent regularStudent = new RegularStudent
            {
                Name = "Aivy Camajalan",
                Program = "BSIT",
                Section = "IT306"
            };
            regularStudent.BasicInfo();// call inherited method to display book information
            regularStudent.SectionEnrolled(); //call method to display regular students details

            IrregularStudent irregularStudent = new IrregularStudent
            {
                Name = "Mary Joyce Camero",
                Program = "BSIT",
                UnitsEnrolled = "18 units"
            };
            irregularStudent.BasicInfo();
            irregularStudent.EnrolledSemUnits();//call method to display irregularstudent

            Console.ReadKey();
        }
    }
}
