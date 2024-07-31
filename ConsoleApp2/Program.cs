using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{

			//Practicing 2D Arrays
			Console.WriteLine(" - 2D Array - \n");


			//There are two types of 2D- Arrays:

			//Rectangular Array: The array whose rows and columns are equal

			//Jagged Array: The array whose rows and columns are not equal

			Console.WriteLine("\nRectangular_Arrays\n");
			int[,] arra1 = { {2,6,9},{4,7,9} , { 3,5,6} };

			Console.WriteLine("GetLenght: "+arra1.GetLength(1));
			Console.WriteLine("GetLenght: "+ arra1.GetLength(0));
			Console.WriteLine("Lenght: "+ arra1.Length);

			Console.WriteLine("\nRectangular Array - Same No. of Row and Coloumn");
			//Following is the Array anf GetLenght give the lenght of rows
			for (int l = 0; l < arra1.GetLength(0);l++)
			{
				for(int g = 0; g < arra1.GetLength(1); g++)
				{
					Console.Write(arra1[l,g]+" ");
				}
				Console.WriteLine();
				
			}


			//Jagged Arrays
			Console.WriteLine("\nJagged_Arrays\n");
			int[][] arra2 = new int[][]
				{ 
				new int[]{ 2, 6 },
				new int[]{ 4, 7, 9 },
				new int[]{3, 5, 6 } 
				};

			Console.WriteLine("\nJagged Array - Different No. of Row and Coloumn");
			//Following is the Array anf GetLenght give the lenght of rows
			for (int l = 0; l < arra2.GetLength(0); l++)
			{
				for (int g = 0; g < arra2[l].Length; g++)
				{
					Console.Write(arra2[l][g] + " ");
				}
				Console.WriteLine();

			}


			//So there is a different in publishing the jagged array
			//in Jagged - its array of arrayes

			//So array1-2-3-4-5 and then it's grouped


			Console.ReadKey();

		}
	}
}

