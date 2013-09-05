/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 09.08.2013
 * Time: 19:45
 */
using System;
using System.Collections.Generic;

namespace ImplementingProgramFlow
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			int? x = null;
			int y = x ?? -1;
			Console.WriteLine(y);
			
			int? c = null;
			int? z = null;
			int d = c ?? z ?? -1;
			Console.WriteLine(d);
			
			Console.WriteLine(GetValue(true));
			
			int[] values = { 1, 2, 3, 4, 5, 6 };
			for (int index = 0; index < values.Length; index += 2)
			{
				Console.Write(values[index]);
			}
			Console.WriteLine();
			
			for (int index = 0; index < values.Length; index++)
			{
				if (values[index] == 4) break;
				
				Console.Write(values[index]);
			}
			Console.WriteLine();
			
			for (int index = 0; index < values.Length; index++)
			{
				if (values[index] == 4) continue;
				
				Console.Write(values[index]);
			}
			Console.WriteLine();
			
			CannotChangeForeachIterationVariable();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		private static int GetValue(bool p)
		{
//			if (p)
//				return 1;
//			else
//				return 0;
			
			return p ? 1 : 0;
		}
		
		static void CannotChangeForeachIterationVariable()
		{
			var people = new List<Person>()
			{
				new Person() { FirstName = "John", LastName = "Doe" },
				new Person() { FirstName = "Jane", LastName = "Doe" }
			};
			
			foreach (Person p in people)
			{
				Console.WriteLine("Person before change: Firstname = {0}, Lastname = {1}", p.FirstName, p.LastName);
			}
			
			foreach (Person p in people)
			{
				p.LastName = "Changed";
				//p = new Person(); // Compile Error
			}
			
			foreach (Person p in people)
			{
				Console.WriteLine("Person after change: Firstname = {0}, Lastname = {1}", p.FirstName, p.LastName);
			}
		}
	}
	
	class Person
	{
		public String FirstName { get; set; }
		public String LastName { get; set; }
	}
}