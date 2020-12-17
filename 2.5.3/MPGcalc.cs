using System;

namespace _2._5._3
{
    class MoreOnNumericTypes
    {
        static void Main(string[] args)
        {
            //ask user for numMiles driven and gasConsumed(per gal)
            //print mpg

            Console.WriteLine("Please enter the number of miles you have driven: ");
            double milesDriven = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the amount of gas consumed (in gallons): ");
            double gas = double.Parse(Console.ReadLine());

            double mpg = milesDriven / gas;

            Console.WriteLine("The total miles-per-gallon you have driven is: {0}", mpg);

        }
    }
}
