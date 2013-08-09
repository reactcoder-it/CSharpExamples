/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 14:01
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizingResourcesExample
{
	/// <summary>
	/// В данном примере для уведомления пользователей о завершении
	/// задачи используется вызов OperationCancelledException. Который
	/// в свою очередь собирается классом AggregateException.
	/// </summary>
	public class ThrowingOperationCancelledException
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
				token.ThrowIfCancellationRequested();
			}, token);
			
			try
			{
				Console.WriteLine("Press enter to stop the task");
				Console.ReadLine();
				
				cancellationTokenSource.Cancel();
				task.Wait();
			}
			catch (AggregateException e)
			{
				Console.WriteLine(e.InnerExceptions[0].Message);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
