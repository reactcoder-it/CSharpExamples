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
	/// Данный пример показывает что происходит при обработке
	/// глобальной переменной несинхронизированными потоками.
	/// В данном примере вывод не будет иметь одинаковый результат.
	/// </summary>
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			int n = 0;
			
			var up = Task.Run(() =>
			{
				for (int i=0; i<1000000; i++)
					n++;
			});
			
			for (int i=0; i<1000000; i++)
					n--;
			
			up.Wait();
			Console.WriteLine(n);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}