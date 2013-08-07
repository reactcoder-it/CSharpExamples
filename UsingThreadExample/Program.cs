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
		[ThreadStatic]
		public static int _field;
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			new Thread(() =>
			{
		       	for (int x=0; x<10; x++)
		       	{
		       		_field++;
		       		Console.WriteLine("Thread A: {0}", _field);
		       	}
			}).Start();
			
			new Thread(() =>
			{
		       	for (int x=0; x<10; x++)
		       	{
		       		_field++;
		       		Console.WriteLine("Thread B: {0}", _field);
		       	}
			}).Start();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}