using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAgain
{
    class Program
    {
        static void Main(string[] args)
        {
           /* String[] names = new string[] { "Eddie", "Parker", "Paige", "Heather" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */
            String zig = "you can get what you want out of life " + "if you help enough people get what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
                Console.Write(zigChar);

            Console.ReadLine();
        
        
        
        }

    }
}
