using System.Collections;

class Program
{
    static void Main()
    {
        Console.WriteLine("HashTable Practice\n\n");


        ///Hashtable Example is as follows:
        ///

        Hashtable Ht = new Hashtable();

        Ht.Add("EmpID",1000);
        Ht.Add("EmpName","Jone");
        Ht.Add("EmpSalary",10000);
        Ht.Add("Location","Norway");


        Console.WriteLine("\nHashtable is published in Key Value Pair for traversing we need Key\nHashtable is like a dic\n\nHashtable1: ");
        foreach(var i in Ht.Keys)
        {
            Console.WriteLine("Key: "+i+" Value:" + Ht[i]);
        }

        ///Printing the independent Values based on Keys
        Console.WriteLine("\n\n\nEmployee Location based on the Key: ");
        Console.WriteLine("The location of the Employee is as follows: {0}\n\n", Ht["Location"]);

        ///
        ///Adding the elemets to the Hashtable
        Ht.Add("Office Locations","Pune, Mumbai, Hyd, Bangalore");
        Console.WriteLine("Added new list of elements to the Ht above Key naming: Office Locations - lets check ");
        Console.WriteLine("The office Locations is as follows: {0}\n\n", Ht["Office Locations"]);

        ////We can remove the objects with the help of key => HashtableName.Remove(Key)
        ///

        ////We can also assign values to the hashtable like Ht[30] = "Value";
        Console.WriteLine("values to the hashtable like Ht[30] = Value\n\n\n");
        Ht[30] = "Index Value";
        foreach (var i in Ht.Keys)
        {
            Console.WriteLine("Key: " + i + "\t Value:" + Ht[i]);
        }

        ////IMP for DictonaryEntry the value of KEYS should be INT !!***

        Console.ReadKey();
    }
}