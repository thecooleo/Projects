using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoterAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age you must be atleast 18 to vote");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote Hurry!\n Choose Wisely! ");
                Console.ReadLine();

            }
            else if (age <= 17) 
            {
                Console.WriteLine("you are not old enough to vote.\n Please come back when you are 18 or older");
                Console.ReadLine();
            }
            else if (age <=0)
            {
                Console.WriteLine("You are not born yet please try again when you are");
                Console.ReadLine();
            }
            else if (age>=90)
            {
                Console.WriteLine("You are dead you have lost your right to vote");
                Console.ReadLine();
            }
        }
    }
}
