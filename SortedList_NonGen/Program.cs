using System.Collections;
class Program
{
    static void Main()
    {
        Console.WriteLine("SortedList Practice\n\n");

        ////SortedList is same as Hashtable and saves the data in Key-Value pair
        ////The Keys are of same datatype and are sorted
        ///
        
        SortedList sortedList = new SortedList();

        sortedList.Add(1,"ONe");
        sortedList.Add(2,"Two");
		sortedList.Add(4, "Four");
        sortedList.Add(3, "Three");
        sortedList.Add(23, "One Two Three");
        

        try
        {
            sortedList.Add(3, "None");  //Duplicate Key not allowed
        }
        catch (Exception ex)
        {
            Console.WriteLine("\n"+ex.ToString());
        }

		////Duplicated - NULL Value is allowed but not Key

		try
		{
			sortedList.Add("eith", null);  //Duplicate Key not allowed
		}
		catch (Exception ex)
		{
			Console.WriteLine("\n" + ex.ToString());
		}

        Console.WriteLine("\nAccessing the using for loop SortedList: ");
        for (int i = 0; i < sortedList.Count; i++)
        {
            Console.WriteLine(sortedList.GetKey(i)+" \t the Value is: "+sortedList.GetByIndex(i));
        }

		Console.WriteLine("\n\nAccessing the using foreach loop SortedList: ");
        foreach (DictionaryEntry t in sortedList)
        {
            Console.WriteLine("Key: "+t.Key+" Value: "+t.Value);
        }



		Console.ReadKey();
	}
}