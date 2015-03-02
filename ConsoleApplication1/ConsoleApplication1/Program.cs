using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("welcome to the program get over 50 to win");
            Random rng = new Random();
            int Player = rng.Next(1,2);
            int random = rng.Next(1, 99);
            Console.WriteLine(random);
            int Random = rng.Next(99, 999);
            if (Player = ) Console.WriteLine("you win");
            {
                Console.WriteLine(random * Random);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("you lose play again");
                Console.ReadLine();
            }






        }
    }
}
