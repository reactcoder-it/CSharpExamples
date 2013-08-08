/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 07.08.2013
 * Time: 10:49
 */
using System;
using System.Threading;

namespace UsingThreadExample
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			ThreadPool.QueueUserWorkItem((s) =>
			{
				Console.WriteLine("\nWorking on a thread from threadpool");
			});
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}