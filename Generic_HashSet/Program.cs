namespace Generic_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic HashSet");


            HashSet<string> hset = new HashSet<string>()
            {"James", "Thor","Lars", "Oyvidn","Lars" };


            Console.WriteLine("\nAccessing the HashSet using foreach: ");
            foreach (string h in hset)
            {
                Console.Write(h+" ");
            }

            hset.Add("Lars"); //will not throw any error but will not add only UNIQUE values


            int hset_1 = hset.RemoveWhere(x => x.StartsWith("L"));

            Console.WriteLine("\n\nAfter removing the element starting from 'L' : ");
            
            foreach (string h in hset)
            {
                Console.Write(h + " ");
            }



            Console.WriteLine("\n\nPrinting with only if condition i.e. Contains condition: ");
            if (hset.Contains("Thor"))
            {
                Console.WriteLine("\nYes the keyword is there in the HashSet");
            }
            else
            {
                Console.WriteLine("\nDoesn't have the keyword");
            }





            Console.ReadKey();
        }
    }
}
