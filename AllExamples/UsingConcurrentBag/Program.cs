/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 8:36
 */
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace UsingConcurrentBag
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			ConcurrentBag<int> bag = new ConcurrentBag<int>();
			
			Task.Run(() =>
			{
				bag.Add(42);
				Thread.Sleep(1000);
				bag.Add(21);
			});
			
			Task.Run(() =>
			{
				foreach (int i in bag)
					Console.WriteLine(i);
			}).Wait();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}