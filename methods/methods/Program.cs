using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            String myvalue = superSecretFormula("World");
            Console.WriteLine(myvalue);
            Console.ReadLine();


        }

        private static string supersecretformula(){
            return "Hello World!";

        }

        private static string superSecretFormula(string name)
        {
            return string.Format("Hello, {0}!", name);

        }
            

    }
}
