using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "black";
            myCar.Year = 2005;

            printVehicleDetails(myCar);
            Truck myTrcuk = new Truck();
            myTrcuk.Make = "Ford";
            myTrcuk.Model = "F950";
            myTrcuk.Year = 2006;
            myTrcuk.Color = "Black";
            myTrcuk.Towingcapicity = 1200;
            printVehicleDetails(myTrcuk);
            Console.ReadLine();


        }

        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the vehicle's details: {0}", vehicle.FormatMe());
            

        }




    }
    abstract class Vehicle
    {
        public string Make { get; set; }
        public String Model { get; set; }
        public int Year { get; set; }
        public String Color { get; set; }

        public abstract string FormatMe();
    }

   class Car : Vehicle
   {

       public override string FormatMe()
       {
           return String.Format("{0} - {1} - {2} - {3}",
               this.Make,
               this.Model,
               this.Year,
               this.Color);
           

       }
   }

    sealed class Truck : Vehicle
    {
        public int Towingcapicity { get; set; }

        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Towing units!",
                this.Make,
                this.Model,
                this.Towingcapicity);


        }
    }
}


