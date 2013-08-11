/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 11.08.2013
 * Time: 13:13
 */
using System;

namespace CreateAndImplementEvents
{
	class Program
	{
		public delegate int Calculate(int x, int y);
		public static int Add(int x, int y) { return x + y; }
		public static int Multiply(int x, int y) { return x * y; }
		
		public static void UseDelegate()
		{
			Calculate calc = Add;
			Console.WriteLine(calc(3,4));
			
			calc = Multiply;
			Console.WriteLine(calc(3,4));
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			UseDelegate();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}