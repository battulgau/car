using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car.Garchig = "!!! Mashinii Medeelel !!!\n";
            //Car.Garchig_hevleh();
            Car myCar = new Car("Toyoto Prius 30", "NHW203456068", "Suvdan tsagaan", 2008, 'B', "1533 OPA");
            Console.WriteLine(myCar.Mashinii_medeelel_avah());
            Console.ReadLine();
            
        }
    }
}
