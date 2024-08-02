using System.Collections;
using System.Collections.Generic;
class Program
{
	static void Main()
	{
		Console.WriteLine("Generic_Collections_in_C# \n");

		////Generic Collections in C# -  type-safe | only one-type of data supported | 
		///


		//Stack
		Stack<int> stackInteger = new Stack<int>();
		//LIFO 
		stackInteger.Push(1);   //adding the int in stack Push()
		stackInteger.Push(6);
		stackInteger.Push(10);

		Console.WriteLine("\nAccessing the stack by foreachloop: ");
		foreach (int i in stackInteger)
		{
			Console.Write(i + " ");
		}

		//List
		List<int> list = new List<int>();

		list.Add(293);
		list.Add(235);  //adding the int in list
		list.Add(121);

		Console.WriteLine("\n\nAccessing the list by foreachloop: ");
		foreach (int g in list)
		{
			Console.Write(g + " ");
		}


		//SortedList
		SortedList<string, string> sortedList = new SortedList<string, string>();

		sortedList.Add("CG011", "Jon");
		sortedList.Add("CG0123", "Jone");
		sortedList.Add("TCS123", "Simt");

		Console.WriteLine("\nSortedList ");
		Console.WriteLine("\n\nAccessing the list by foreach loop: ");
		foreach (string f in sortedList.Keys)
		{
			Console.Write("Key: " + f + "\n");
		}


		//Dictonary
		Dictionary<int, string> dict = new Dictionary<int, string>();

		dict.Add(345, "Keyl");
		dict.Add(10, "Simt");
		dict.Add(02, "Yest");
		dict.Add(390, "Thor");


		Console.WriteLine("\nDictonary");
		Console.WriteLine("\n\nAccessing the Dictonary by foreach loop: ");
		foreach (KeyValuePair<int, string> f in dict)
		{
			Console.Write("Key: " + f.Key + "\tValues: " + f.Value + "\n");
		}


		//Sorted Dictonary
		SortedDictionary<int, string> sdict = new SortedDictionary<int, string>();

		sdict.Add(345, "Keyl");
		sdict.Add(10, "Simt");
		sdict.Add(02, "Yest");
		sdict.Add(390, "Thor");


		Console.WriteLine("\nSorted Dictonary");
		Console.WriteLine("\n\nAccessing the Dictonary by foreach loop: ");
		foreach (KeyValuePair<int, string> f in sdict)
		{
			Console.Write("Key: " + f.Key + "\tValues: " + f.Value + "\n");
		}

		//HashSet
		HashSet<string> hash = new HashSet<string>();

		hash.Add("Aniket");
		hash.Add("Oracle");
		hash.Add("Equinor");

		Console.WriteLine("\nHashSet");
		Console.WriteLine("\nAccessing the HashSet by foreach loop: ");
		foreach (string i in hash)
		{
			Console.Write(" " + i);
		}



		//Queue
		Queue<string> queue_1 = new Queue<string>();
		//FIFO
		queue_1.Enqueue("Q-1"); //Adding data by Enqueue in the Queue
		queue_1.Enqueue("Q-2");
		queue_1.Enqueue("Q-3");

		Console.WriteLine("\nQueue");
		Console.WriteLine("\nAccessing the Queue by foreach loop: ");
		foreach (string i in queue_1)
		{
			Console.Write(" " + i);
		}

		Console.WriteLine("Removing the first element :  "+ queue_1.Dequeue());

		Console.WriteLine("\nAccessing the Queue by foreach loop after Dequeue: ");
		foreach (string i in queue_1)
		{
			Console.Write(" " + i);
		}

		//


		Console.ReadKey();
	}
}