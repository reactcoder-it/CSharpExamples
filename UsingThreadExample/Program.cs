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
		public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
		{
			return Thread.CurrentThread.ManagedThreadId;
		});
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			new Thread(() =>
			{
		       	for (int x=0; x<_field.Value; x++)
		       	{
		       		Console.WriteLine("Thread A: {0}", x);
		       	}
			}).Start();
			
			new Thread(() =>
			{
		       	for (int x=0; x<_field.Value; x++)
		       	{
		       		Console.WriteLine("Thread B: {0}", x);
		       	}
			}).Start();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}