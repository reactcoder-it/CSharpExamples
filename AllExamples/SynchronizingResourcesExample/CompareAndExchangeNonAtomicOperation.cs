/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 13:37
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizingResourcesExample
{
	/// <summary>
	/// В данном примере используются атомарные операции
	/// CompareExchange для замены значения переменной @value.
	/// </summary>
	public class CompareAndExchangeNonAtomicOperation
	{
		static int @value = 1;
		
		static void Main()
		{
			var t1 = Task.Run(() =>
			{
				Thread.Sleep(1000);
				Interlocked.CompareExchange(ref @value, 2, 1);
			});
			
			var t2 = Task.Run(() =>
			{
				Interlocked.CompareExchange(ref @value, 3, 1);
			});
			
			Task.WaitAll(t1, t2);
			Console.WriteLine(@value);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
