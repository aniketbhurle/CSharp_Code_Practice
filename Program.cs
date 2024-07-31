using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Practicing Array
			int[] array1 = { 1,2,3,4, 5};

			//Accessing Array with Foreach loop
			Console.WriteLine("\n Accessing array with foreach loop");
			foreach (int i in array1)
			{
				Console.WriteLine("{0} ",i);

			}

			//Accessing array with for loop
			Console.WriteLine("\n Accessing array with for loop");

			for(int i=0; i<array1.Length;i++)
			{
				Console.WriteLine("{0} ", array1[i]);
			}


			//=====



			string[] Countries = { "India", "USA", "UK" };
			Console.WriteLine("\n\n++Accessing array with for loop");
			for(int j=0; j<Countries.Length;j++)
			{
				Console.Write(Countries[j]+" ");
			}

			//the for-each loop, the data type of the loop variable must be
			//the same as the type of the values stored in the array. 

			Console.WriteLine("\n\n++Accessing string array with foreach loop");
			
			foreach(string k in Countries)
			{
				Console.Write(k + " ");
			}


			//Assigning a new value
			Countries.Append("Ireland");

			//Implicitly Typed array
			var arr = new[] { 10, 20, 30, 40, 50 };

			Console.WriteLine("\n\n\n++Implicity Typed var array array with for loop");
			foreach (var k in arr)
			{
				Console.Write(k + " ");
			}



			Console.ReadKey();
		}
	}
}
