using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderStandingEnumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            //changing Console color 
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            //Console.WriteLine("Hello World");
            Console.WriteLine("Type in Batman Superman or greenlantern to see his nickname");
            string userValue = Console.ReadLine();

            SuperHero myValue;
            //convert user input to Enum SuperHero
            if (Enum.TryParse<SuperHero>(userValue, true, out myValue))
            {


                switch (myValue)
                {
                    case SuperHero.Batman:
                        Console.WriteLine("Caped crusader");
                        break;
                    case SuperHero.Superman:
                        Console.WriteLine("Man of Steel");
                        break;
                    case SuperHero.GreenLantern:
                        Console.WriteLine("Emerald Knight");
                        break;
                    default:
                        break;
                }
               
            }
            else Console.WriteLine("Does not compute");


            Console.ReadLine();
        }
    }

    //create enum SuperHero
    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern
    }
}
