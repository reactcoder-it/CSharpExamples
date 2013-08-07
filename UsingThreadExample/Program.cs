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
		public static void ThreadMethod() {
			for (int i=0; i<10; i++) {
				Console.WriteLine("ThreadProc: {0}", i);
				Thread.Sleep(0);
			}
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Thread t = new Thread(new ThreadStart(ThreadMethod));
			t.Start();
			
			for (int i=0; i<4; i++) {
				Console.WriteLine("MainThread: Do Some Work.");
				Thread.Sleep(0);
			}
			
			t.Join();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}