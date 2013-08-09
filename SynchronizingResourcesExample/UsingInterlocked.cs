/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 13:29
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizingResourcesExample
{
	/// <summary>
	/// Синхронизацию возможно сделать и другим способом.
	/// Использовать класс Interlocked, которые представляет
	/// атомарные операции, которые не могут быть разделены
	/// на несколько операций.
	/// </summary>
	public class UsingInterlocked
	{
		static void Main()
		{
			int n = 0;
			
			var up = Task.Run(() =>
			{
				for (int i = 0; i < 1000000; i++)
				{
					Interlocked.Increment(ref n);
				}
			});
			
			for (int i = 0; i < 1000000; i++)
			{
				Interlocked.Decrement(ref n);
			}
			
			up.Wait();
			Console.WriteLine(n);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
