/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 08/08/2013
 * Time: 14:01
 */
using System;
using System.Linq;

namespace UsingPLINQExample
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			var numbers = Enumerable.Range(0, 20);
			var parallelResult = numbers
				.AsParallel()
				.Where(i => i % 2 == 0);
			
			parallelResult.ForAll(e => Console.WriteLine(e));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}