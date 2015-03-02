using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            car myCar = new car();

            //set properties

            car myOtherCar = myCar;

            car myThridCar = new car("Ford", "Escape", 2005, "White");



            myOtherCar = null;
            myCar = null;

        }
    }
    class car
    {
        public String Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        public car()
        {
            //You could get this from a configuration file database etc.
            //I'll just hard code in this instance
            this.Make = "Nissan";
        }

        public car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;


        }

    }
}