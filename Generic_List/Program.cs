namespace Generic_List
{
	internal class Program
	{
		static void Main(string[] args)
		{

			List<string> EmpNames = new List<string>();

			EmpNames.Add("Jone SOl");
			EmpNames.Add("Will");
			EmpNames.Add("Jabra");

			List<string> newEmpNames = new List<string>();

			newEmpNames.Add("Uber");
			newEmpNames.Add("Ola");

			Console.WriteLine("\nEmployees: ");
			foreach (string empName in EmpNames)
			{
				Console.Write(empName + " , ");
			}

			EmpNames.AddRange(newEmpNames);


			Console.WriteLine("\nNew Employees: ");
			foreach (string empName in EmpNames)
			{
				Console.Write(empName + " , ");
			}


			//adding Jugnoo infront of Uber


			if( EmpNames.Contains("Uber"))
			{
				int i = EmpNames.IndexOf("Uber");
				EmpNames.Insert((i-1),"Jugnoo");

				Console.WriteLine("\n\n Added Jugnoo before Uber - New Employees: ");
				foreach (string empName in EmpNames)
				{
					Console.Write(empName + " ");
				}
			}
			else
			{
				Console.Write("\nThere is no Uber in Name");
			}


			Console.ReadKey();
		}
	}
}
