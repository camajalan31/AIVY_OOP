using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_InheritanceWithUserInput
{
    class Shoe //base class
    {
        //Declare properties for the Shoe class
        public string Brand { get; set; }
        public string Size { get; set; }

        public void ShoeInfo()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("----Shoe Details----");
            Console.WriteLine("Brand Name: " + Brand);
            Console.WriteLine("Size: " + Size);
        }
    } 

    class Casual : Shoe //derived class
    {
        //Add another properties 
        public string Color { get; set; }
        public int Price { get; set; }
        public void CasualInfo() 
        {
            ShoeInfo(); //call the method to display shoe info
            Console.WriteLine($"Color: {Color} \nPrice: {Price}");
        }

    }

    class Athletic :Shoe //derived class
    {
        //Add another properties 
        public string Color { get; set; }
        public int Price { get; set; }
        public void AthleticInfo() 
        {
            ShoeInfo(); //call the method to display shoe info
            Console.WriteLine($"Color: {Color} \nPrice: {Price}");
        }
    }

}
