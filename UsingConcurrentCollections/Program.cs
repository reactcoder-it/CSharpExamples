/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 8:23
 */
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace UsingConcurrentCollections
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			BlockingCollection<String> col = new BlockingCollection<string>();
			Task read = Task.Run(() =>
			{
				while (true)
				{
					Console.WriteLine(col.Take());
				}
			});
			
			Task write = Task.Run(() =>
			{
				while (true)
				{
					String s = Console.ReadLine();
					if (String.IsNullOrWhiteSpace(s)) break;
					col.Add(s);
				}
			});
			
			write.Wait();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}