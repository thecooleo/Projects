using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderStandingScope
{
    class Program
    {
       // private static string k = "";
       // private static string h = "";

        static void Main(string[] args)
        {
            //string j = "";
          /*  for (int i = 0; i < 10; i++) 
            {
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                    h = l;
                }
                Console.WriteLine("l:" + h);
            }
            //Console.WriteLine(i);
            //Console.WriteLine("Outside of the for: " + k);
            helperMethod();
            */
            Car car = new Car();

            car.DoSomething();


            Console.ReadLine();
        }
        /*
        static void helperMethod()
        {
            Console.WriteLine("k from the helperMethod:" + k);
        }
         */
    }
    class Car
    {
        public void DoSomething(){
            Console.WriteLine(helperMethod());
            

        }

        private string helperMethod()
        {
            return "Hello world!";
        }
    }
}

