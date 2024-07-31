using System.Collections;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nArrayList Practice");

        ArrayList arrayList = new ArrayList();

        arrayList.Add(101);
        arrayList.Add("Aniket");
        arrayList.Add(" ");
        arrayList.Add(4.6);

        arrayList.Add(null);

        Console.WriteLine("\n\n++We can add any values to arraylist the therefore its non-generic: \nAdding elements using .Add()\nArrayList1: ");
        foreach(var i in arrayList)
        {
            Console.Write(i+" ");
        }

        Console.WriteLine("\n\nAdding Elements thriugh object initializer: \nArrayList2: ");
        var ArrayList2 = new ArrayList { 102, "Simth", "Jpne", true, 15.22, 456 };
        foreach(var j in ArrayList2)
        {
            Console.Write(j+" ");
        }


        Console.WriteLine("\n\nAdding Elements in bwetween: \nArrayList3: ");
        var ArrayList3 = new ArrayList { 102, "Simth", "Jpne", true, 15.22, 456 };

        ArrayList3.Insert(2,"Third POsition"); 

        foreach (var j in ArrayList3)
        {
            Console.Write(j + " ");
        }



        Console.WriteLine("\n\nAdding Range of Elements from 2nd position in bwetween: \nArrayList3: ");
        var ArrayList4 = new ArrayList { 102, "Simth", "Jpne", true, 15.22, 456 };

        ArrayList4.InsertRange(2, arrayList );

        foreach (var j in ArrayList4)
        {
            Console.Write(j + " ");
        }


        Console.ReadKey();
    }
}