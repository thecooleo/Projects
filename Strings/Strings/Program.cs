﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = ("Go to your c:\ drive");
            //string myString = "my\"So called\"life";
            //string myString = "What if i need a new line?";
            
            //string myString = string.Format("{0}", "Bonzai")
            //string myString = string.Format("Make: {0} Model: {1}", "BMW", "760li");

            //string myString = string.Format("{0:C}", 123.45);
           // string myString = string.Format("{0:N}", 123456789);
            //string myString = string.Format("{0:P}", .35);
            //string myString = string.Format("{0:(###) ### - ####}", 5197513675);

          /*  StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
           */
            string myString = " That summer we took threes across the board ";

            //myString = myString.Substring(5, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" " , "--");
            myString = string.Format(
                "length before: {0} -- After: {1}", 
                myString.Length, 
                myString.Trim().Length);

            Console.WriteLine(myString);
                Console.ReadLine();
        }
    }
}
