using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ////STACK example - Last in First Out - stack of books / dishes in a reception
        Console.WriteLine("STACK Practice \n\n");


        Stack stack = new Stack();

        stack.Push(1);
        stack.Push("Look");
        stack.Push(235.64);

        //Printing Stack - Pushing
        Console.WriteLine("Pushing the elements in stack: ");
        foreach (var item in stack)
        {
            Console.Write(item+ " , ");
        }

        Console.WriteLine("\n\nThere are almost count elements: "+stack.Count);

        Console.WriteLine("\n\n Using the Pop operation to remove the last element i.e "+stack.Peek() + " this element will be removed after this... \nCheck the following now: \n");

        stack.Pop();
        
        foreach (var item in stack)
        {
            Console.Write(item + " , ");
        }


        Console.WriteLine("\n\nThe count is now deceresed: " + stack.Count);


        Console.ReadKey();
    }
}