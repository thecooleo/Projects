using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose type of Wood\nPine =1\nOak=2\nMahgonay=3");
            Console.ReadLine();
            int Wood = Convert.ToInt32(Console.ReadLine());
            if (Wood ==1)
            {
                Console.WriteLine("Total=$100");
                Console.ReadLine();
            }
            else if (Wood == 2)
            {
                Console.WriteLine("Total=$225");
                Console.ReadLine();
            }
            else if (Wood == 3)
            {
                Console.WriteLine("Total=$310");
                Console.ReadLine();

            }

            else { 
            Console.WriteLine("Total=$0");
            Console.ReadLine();
            }
        }
    }
}
