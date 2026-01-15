using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_InheritanceWithConstructor
{
     class Student
    {
        //Declaration of the fields
        public string name;
        public string program;

        //Constructor
        public Student(string studentName, string studentProgram)
        {
            name = studentName;
            program = studentProgram;
        }
        public void DisplayStudType()
        {
            Console.WriteLine("\n  ---Student Information---");
        }
        public void BasicInfo()
        {
            Console.WriteLine($"     Name: {name} \n     Program: {program}");
        }
    }

    class RegularStudent : Student
    {
        //fields
        public string Section;
        //constructor
        public RegularStudent(string studentName, string studentProgram, string regularstudentSection) : base(studentName, studentProgram)
        {

            Section = regularstudentSection;
        }
        public void DisplayRegStudType()
        {
            Console.WriteLine("\n\n-----Regular Student Information-----\n");
        }

        public void SectionEnrolled()
        {
            DisplayRegStudType();//Call method to display the stud type
            BasicInfo();//Call inherited method to display student info
            Console.WriteLine($"     Section: {Section}");
        }

    }

    class IrregularStudent : Student
    {
        //fields
        public string UnitsEnrolled;
        //Constructor
        public IrregularStudent(string studentName, string studentProgram, string regularstudentSection, string irregularstudentUnitsEnrolled) : base(studentName, studentProgram)
        {
            UnitsEnrolled = irregularstudentUnitsEnrolled;
        }
        public void DisplayIrregStudType()
        {
            Console.WriteLine("\n\n-----Irregular Student Information-----\n");
        }

        public void EnrolledSemUnits()
        {
            DisplayIrregStudType();//Call method to display the stud type
            BasicInfo();//Call inherited method to display student info
            Console.WriteLine($"     UnitsEnrolled: {UnitsEnrolled}");
        }
    }
}
