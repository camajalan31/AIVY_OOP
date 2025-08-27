using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_EncapUserInput
{
    internal class Shoe
    {
        //Declaration of fields
        public string Brand { get; set; }
        public string Price { get; set; }

        public void DisplayShoeDetails()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("----Shoe Details----");
            Console.WriteLine("Brand Name: " + Brand);
            Console.WriteLine("Price: " + Price);



        }
    }
}
