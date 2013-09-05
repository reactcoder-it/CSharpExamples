/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 05.09.2013
 * Time: 19:37
 */
using System;

namespace WorkingWithStrings
{
	class Program
	{
		static void WorkingWithChar()
		{
			Console.WriteLine("--- Working with char ---");
			Console.WriteLine(Char.ToUpper('c'));
			Console.WriteLine(Char.IsWhiteSpace('\t'));
			Console.WriteLine("-------------------------");
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			WorkingWithChar();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
	}
}