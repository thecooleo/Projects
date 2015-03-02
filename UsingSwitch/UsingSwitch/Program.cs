using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a super heros name to see his nickname");
            Console.WriteLine("Select Batman, Green Lantern or SuperMan");
            string userValue = Console.ReadLine();
            switch (userValue.ToUpper())
            {
                case "BATMAN":
                    Console.WriteLine("Caped Crusader");
                    break;
                case "GREEN LANTERN":
                    Console.WriteLine("Emerald Knight");
                    break;
                case "SUPERMAN":
                    Console.WriteLine("Man of Steel");
                    break;
                default:
                    Console.WriteLine("Does not Computer");
                    break;
             }

            Console.ReadLine();
        }
    }
}
