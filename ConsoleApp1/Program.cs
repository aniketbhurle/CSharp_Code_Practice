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
            int[] array1 = { 1, 2, 3, 4, 5 };

            foreach (int i in array1)
            {
                Console.WriteLine("{0} ", i);
            }

            Console.ReadKey();
        }
    }
}
