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
			
			Task[] tasks = new Task[3];
			
			tasks[0] = Task.Factory.StartNew(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("1");
			});
			
			tasks[1] = Task.Factory.StartNew(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("2");
			});
				
			tasks[2] = Task.Factory.StartNew(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("3");
			});
			
			Task.WaitAll(tasks);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}