/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 8:36
 */
using System;
using System.Collections.Concurrent;

namespace UsingConcurrentBag
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			ConcurrentBag<int> bag = new ConcurrentBag<int>();
			bag.Add(42);
			bag.Add(21);
			
			int result;
			if (bag.TryTake(out result))
				Console.WriteLine(result);
			
			if (bag.TryPeek(out result))
				Console.WriteLine("There is a next item: {0}", result);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}