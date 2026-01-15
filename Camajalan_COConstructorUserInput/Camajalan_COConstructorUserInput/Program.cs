using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_COConstructorUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Aivy Camajalan_IT306
        //Title:User Input with Constructor
        Main:
            Console.Clear();
            Console.WriteLine("This program will ask you about student details.\n\n");
            Console.Write("Name of student: \t");
            string vName = Console.ReadLine();

            Console.Write("Section of the student: \t");
            string vSection = Console.ReadLine();

            Console.Write("Course of the student: \t");
            string vCourse = Console.ReadLine();    

            //Initiate a class object
            Students students1 = new Students (vName, vSection, vCourse);

            //Call the Method to display  the Student details Information
            students1.DisplayStudentsDetails();

            //Input another Student details
            Console.WriteLine("\n Do you want to input another student details (yes/no)?  ");
            string ans =Console.ReadLine();

            if (ans == "yes") 
            { 
                goto Main;
            }
            else if (ans == "no")
            {
                return;
            }
                
        }
    }
}
 