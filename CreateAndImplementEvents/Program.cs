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
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			UseDelegate();
			
			Multicast();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		#region -= Using delegates =-
		
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
		
		#endregion
		
		#region -= Multicast Delegate =-
		
		public static void MethodOne()
		{
			Console.WriteLine("MethodOne");
		}
		
		public static void MethodTwo()
		{
			Console.WriteLine("MethodTwo");
		}
		
		public delegate void Del();
		
		public static void Multicast()
		{
			Del d = MethodOne;
			d += MethodTwo;
			
			d();
			
			int invocationCount = d.GetInvocationList().GetLength(0);
			Console.WriteLine(invocationCount);
		}
		
		#endregion
	}
}