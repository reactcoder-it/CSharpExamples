/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 07.08.2013
 * Time: 10:49
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UsingThreadExample
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Task t = Task.Factory.StartNew(() =>
			{
	           	for (int x=0; x<100; x++)
	           	{
	           		Console.Write('*');
	           		Thread.Sleep(200);
	           	}
			});
			
			t.Wait();
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}