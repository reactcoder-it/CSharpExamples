/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 31.07.2013
 * Time: 21:37
 */
using System;

namespace ScopeExample
{
	class Program
	{
		static int j = 20;
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			int j = 30;
			Console.WriteLine("j = " + j);
			Console.WriteLine("Program.j = " + Program.j);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}