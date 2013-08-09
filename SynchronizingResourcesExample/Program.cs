/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 10:09
 */
using System;
using System.Threading.Tasks;

namespace SynchronizingResourcesExample
{
	/// <summary>
	/// Одной из возможностей синхронизации является использование
	/// оператора lock. После его использования программа будет
	/// всегда выводить значение = 0, поскольку теперь доступ к
	/// переменной синхронизирован.
	/// </summary>
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			int n = 0;
			var _lock = new Object();
			
			var up = Task.Run(() =>
			{
				for (int i=0; i<1000000; i++)
					lock (_lock)
						n++;
			});
			
			for (int i=0; i<1000000; i++)
				lock (_lock)
					n--;
			
			up.Wait();
			Console.WriteLine(n);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}