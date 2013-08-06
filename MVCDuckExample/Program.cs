/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 12:30
 */
using System;

namespace MVCDuckExample
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine("============================");
			
			DuckSimulator simulator = new DuckSimulator();
			AbstractDuckFactory duckFactory = new CountingDuckFactory();
			
			simulator.Simulate(duckFactory);
			
			Console.WriteLine("============================");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}