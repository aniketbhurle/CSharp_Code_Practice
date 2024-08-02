using System.Collections.Generic;
using System;

namespace Generic_Complex_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Complex List and Operations \n");

            //Sorting in Complex Lists
            List<Employee> listemployee = new List<Employee>()
            {
                new Employee(){ empId=1001,empName="ANiket",empSalary=34523},
                new Employee(){ empId=1002,empName="Janurat",empSalary=1230},
                new Employee(){ empId=1003,empName="Jone",empSalary=2345}
            };

            Console.WriteLine("\nEmployees Before Sorting: ");
            foreach (Employee emp in listemployee)
            {
                Console.WriteLine(emp.empId +" "+emp.empName+" "+emp.empSalary);
            }

            listemployee.Sort();
            Console.WriteLine("\nEmployees After Sorting: ");
            foreach (Employee emp in listemployee)
            {
                Console.WriteLine(emp.empId + " " + emp.empName + " " + emp.empSalary);
            }

            listemployee.Sort();
            Console.WriteLine("\nEmployees After Sorting: ");
            foreach (Employee emp in listemployee)
            {
                Console.WriteLine(emp.empId + " " + emp.empName + " " + emp.empSalary);
            }

            //Sorting with LINQ

            listemployee = listemployee.OrderBy(x => x.empName).ToList();
            Console.WriteLine("\nEmployees After Sorting by LINQ by Name: ");
            foreach (Employee emp in listemployee)
            {
                Console.WriteLine(emp.empId + " " + emp.empName + " " + emp.empSalary);
            }


            Console.ReadKey();
        }

        public class Employee : IComparable<Employee>,IComparer<Employee>
        {
            public string empName { get; set; }
            public int empId { get; set; }
            public int empSalary { get; set; }

            public int CompareTo(Employee obj)
            {
                if(this.empSalary > obj.empSalary)
                {
                    return 1;
                }
                else if (this.empSalary < obj.empSalary)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

            public int Compare(Employee x, Employee y)
            {
                return x.empName.CompareTo(y.empName);
            }



        }
    }
}
