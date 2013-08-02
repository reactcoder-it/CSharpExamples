/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 02.08.2013
 * Time: 11:42
 */
using System;

namespace TemplateMethodPatternExample
{
	class DuckSortTestDrive
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Duck[] ducks = {
				new Duck("Daffy", 8),
				new Duck("Dewey", 2),
				new Duck("Howard", 7),
				new Duck("Louie", 2),
				new Duck("Donald", 10),
				new Duck("Huey", 2)
			};
			
			Console.WriteLine("Before sorting:");
			Display(ducks);
			
			Array.Sort(ducks);
			
			Console.WriteLine("\nAfter sorting:");
			Display(ducks);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void Display(Duck[] ducks)
		{
			for (int i=0; i<ducks.Length; i++) {
				Console.WriteLine(ducks[i]);
			}
		}
	}
}