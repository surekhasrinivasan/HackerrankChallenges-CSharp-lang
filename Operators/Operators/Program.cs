using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    // Arithmetic Operators 
    // Given the meal price (base cost of a meal), tip percent (the percentage of the meal price being added as tip), 
    // and tax percent (the percentage of the meal price being added as tax) for a meal, find and print the meal's total cost.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter meal_cost: ");
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter tip_percent: ");
            int tip_percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter tax_percent: ");
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            double tip = (meal_cost * tip_percent) / 100;

            double tax = (meal_cost * tax_percent) / 100;

            double total_cost;

            total_cost = meal_cost + tip + tax;

            Console.WriteLine("Total meal cost : " + Math.Round(total_cost));
        }
    }
}
