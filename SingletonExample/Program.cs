/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 11:20
 */
using System;

namespace SingletonExample
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			RateImplementation theRate = new RateImplementation();
			RateImplementation theRate2 = new RateImplementation();
			Console.WriteLine("theRate : " + theRate.GetRate());
			Console.WriteLine("theRate2: " + theRate2.GetRate());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}