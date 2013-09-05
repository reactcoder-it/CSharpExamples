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
			
			try
			{
				var parallelResult = numbers
					.AsParallel()
					.Where(i => IsEven(i));
			
				parallelResult.ForAll(e => Console.WriteLine(e));
			}
			catch (AggregateException e)
			{
				Console.WriteLine("There where {0} exceptions", e.InnerExceptions.Count);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static bool IsEven(int i)
		{
			if (i % 10 == 0) throw new ArgumentException("i");
			
			return i % 2 == 0;
		}
	}
}