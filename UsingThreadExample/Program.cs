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
			
			ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
			{
				if (i == 500)
				{
					Console.WriteLine("Breaking loop");
					loopState.Break();
				}
				return;
			});
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}