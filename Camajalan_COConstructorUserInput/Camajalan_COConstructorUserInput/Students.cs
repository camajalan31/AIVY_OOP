using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_COConstructorUserInput
{
    internal class Students
    {
        //I'm changing my class and is not the same on exercise 2
        // Declaration of the fields
        public string name;
        public string section;
        public string course;

        public Students(string vName, string vSection, string vCourse)
        {
            name = vName;
            section = vSection;
            course = vCourse;
        }
        public void DisplayStudentsDetails()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("----Student Details----");
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Section: " + section);
            Console.WriteLine("Student Course: " + course);


        }
    }
}