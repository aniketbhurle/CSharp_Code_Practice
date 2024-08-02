using System.Linq;

namespace Generic_Dictonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary Demos: ");


            Dictionary<string, string> dict_1 = new Dictionary<string, string>()
            {
                {"India","Delhi, Pune Maharashtra, MP, Rajasthan"},
                {"USA","Chicago, New York, Washington " },
                {"UK", "London Manchester" }
            };

            Console.WriteLine("\nDictonary Acccessing the by foreach loop: ");
            foreach (KeyValuePair<string, string> kvp in dict_1)
            {
                Console.WriteLine("Key: "+kvp.Key+" Value: "+kvp.Value);
            }

            dict_1.Add("New Country", "New Cities"); //Adding new value
            dict_1["NULL"] = "Null Values to be added";

            if(dict_1.ContainsKey("USA"))
            {
                Console.WriteLine("\n++The USA key is there in the dict");
            }
            else
            {
                Console.WriteLine("\nNot available in dict");
            }

            Console.WriteLine("\n++Accessing the dictonary with AsParallel().ForAll():\n");
            dict_1.AsParallel().ForAll(dict => Console.WriteLine(dict.Key+" : "+dict.Value));

            Dictionary<int, Employee> emp_1 = new Dictionary<int, Employee>()
            {
                {101, new Employee{empID=1000, empGender="Male", empName="Aniket" } },
                {106, new Employee{empID=1023, empGender="Male", empName="Amol" } },
                {104, new Employee{empID=10245, empGender="Female", empName="AJanema" } },
                {100, new Employee{empID=1020, empGender="Male", empName="Jon" } }
            };


            Console.WriteLine("\n++Accessing the dictonary as Complex:\n");
            foreach (KeyValuePair<int,Employee> kvp in emp_1)
            {
                Console.WriteLine(kvp.Key+" : "+kvp.Value.empID + " : " +kvp.Value.empName + " : " +kvp.Value.empGender);
            }


            Console.WriteLine("\nSorting the Dictonary with LINQ :"); 

            var emp_11 = emp_1.ToList();
            emp_11 = emp_11.OrderBy(x => x.Value.empID).ToList();
            foreach (var item in emp_11)
            {
                Console.WriteLine(item.Key+" : "+item.Value.empName + " : " +item.Value.empID + " " +item.Value.empGender);
            }




            Console.ReadKey();
        }

        public class Employee
        {
            public int empID { get; set; }
            public string empName { get; set; }
            public string empGender { get; set; }
        }
    }
}
