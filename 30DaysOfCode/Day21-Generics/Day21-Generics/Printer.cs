using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_Generics
{
	// Write a single generic function named printArray; this function must take an array of generic elements as a parameter.

	class Printer
	{
		/**
	*    Name: PrintArray
	*    Print each element of the generic array on a new line. Do not return anything.
	*    @param A generic array
	**/
		// Write your code here
		static void PrintArray<T>(int[] intArray)
		{
			for(int i = 0; i < intArray.Length; i++)
			{
				Console.WriteLine(intArray[i]);
			}
		}

		static void PrintArray<T>(String[] stringArray)
		{
			for(int i = 0; i < stringArray.Length; i++)
			{
				Console.Write(stringArray[i]);
			}
		}


		static void Main(string[] args)
		{
			Console.WriteLine("Enter an integer: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] intArray = new int[n];
			Console.WriteLine("Enter the elements of the array: ");
			for (int i = 0; i < n; i++)
			{
				intArray[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("Enter the number of characters in a string: ");
			n = Convert.ToInt32(Console.ReadLine());
			string[] stringArray = new string[n];
			Console.WriteLine("Enter the string: ");
			for (int i = 0; i < n; i++)
			{
				stringArray[i] = Console.ReadLine();
			}

			PrintArray<Int32>(intArray);
			Console.WriteLine();
			PrintArray<String>(stringArray);
			Console.WriteLine();
		}
	}
}
