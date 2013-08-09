/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 13:52
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizingResourcesExample
{
	/// <summary>
	/// В данном примере используется класс CancellationTokenSource для сигнализации
	/// задачи об отмене операции.
	/// </summary>
	public class UsingCancellationToken
	{
		static void Main()
		{
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			CancellationToken token = cancellationTokenSource.Token;
			
			var task = Task.Run(() =>
			{
				while (!token.IsCancellationRequested)
				{
					Console.Write("*");
					Thread.Sleep(1000);
				}
			}, token);
			
			Console.WriteLine("Press enter to stop the task");
			Console.ReadLine();
			cancellationTokenSource.Cancel();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
