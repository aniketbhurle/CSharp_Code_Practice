using System.Collections;

class Program
{
    static void Main()
    {
        ////QUEUE example - First In First Out - Queue in a store or in a cinema house.
        Console.WriteLine("QUEUE Practice \n\n");


        Queue queue_var = new Queue();

        queue_var.Enqueue(1000);
        queue_var.Enqueue("Jone Sole");
        queue_var.Enqueue(34.245);
        queue_var.Enqueue(true);

        //Printing Queue - Enqueuing - adding the elements
        Console.WriteLine("Enqueuing the elements in queue: ");
        foreach (var item in queue_var)
        {
            Console.Write(item + " , ");
        }

        Console.WriteLine("\n\nThere are almost count elements: " + queue_var.Count);

        Console.WriteLine("\n\n Using the Pop operation to remove the last element i.e " + queue_var.Peek() + " this element will be removed after this... \nCheck the following now: \n");

        queue_var.Dequeue();

        foreach (var item in queue_var)
        {
            Console.Write(item + " , ");
        }


        Console.WriteLine("\n\nThe count is now deceresed: " + queue_var.Count);


        Console.ReadKey();
    }
}