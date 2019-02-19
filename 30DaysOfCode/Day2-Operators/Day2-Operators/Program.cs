using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Operators
{
    // Arithmetic Operators
    // Print the total meal cost, where totalCost is the rounded integer result of the entire bill (mealCost with added tax and tip)
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }

        // Complete the solve function below.
        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

            double tip;
            tip = (meal_cost * tip_percent) / 100;

            double tax;
            tax = (meal_cost * tax_percent) / 100;

            double total_cost;

            total_cost = meal_cost + tip + tax;

            Console.WriteLine(Math.Round(total_cost));
        }
    }
}
