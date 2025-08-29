using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_Class_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aivy Camajalan_IT306
            //Problem: Create your preferred Class
            //There should be at least 3 attributes / fields
            //Your class method must be usable by both objects to display their information
            //Instantiate two class objects

            //instantiate two object
            Students students1 = new Students();
            Students students2 = new Students();

            //initialization of fields
            students1.name = "Aivy Camajalan";
            students1.section = "IT306P";
            students1.course = "Bachelor of Science in Information Technology";

            students2.name = "Karan Singh";
            students2.section = "TM301P";
            students2.course = "Bachelor of Science in Tourism Management";

            Console.WriteLine("\nStudents: \n");
            //call the method to display information
            students1.DisplayInfo();
            students2.DisplayInfo();

            Console.ReadKey();
        }
    }
}
