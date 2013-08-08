/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 07.08.2013
 * Time: 10:49
 */
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UsingThreadExample
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Parallel.For(0, 10, i =>
			{
				Thread.Sleep(1000);
			});
			
			var numbers = Enumerable.Range(0, 10);
			Parallel.ForEach(numbers, i =>
			{
				Thread.Sleep(1000);
			});
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}