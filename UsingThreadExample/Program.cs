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
		public static void ThreadMethod(Object o)
		{
			for (int i=0; i<(int)o; i++)
			{
				Console.WriteLine("ThreadProc: {0}", i);
				Thread.Sleep(0);
			}
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			bool stopped = false;
			
			Thread t = new Thread(new ThreadStart(() =>
			{
				while (!stopped)
				{
					Console.WriteLine("Running...");
					Thread.Sleep(1000);
				}
			}));
			
			t.Start();
			Console.Write("Press any key to exit . . . ");
			Console.ReadKey(true);
			
			stopped = true;
			t.Join();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}