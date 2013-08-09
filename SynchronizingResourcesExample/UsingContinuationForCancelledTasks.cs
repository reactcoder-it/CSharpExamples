/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 14:10
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizingResourcesExample
{
	/// <summary>
	/// Description of UsingContinuationForCancelledTasks.
	/// </summary>
	public class UsingContinuationForCancelledTasks
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
			}, token).ContinueWith((t) =>
			{
				t.Exception.Handle((e) => true);
				Console.WriteLine("You have cancelled the task");
			}, TaskContinuationOptions.OnlyOnCanceled);
			
			Console.WriteLine("Press enter to stop the task");
			Console.ReadLine();
			
			cancellationTokenSource.Cancel();
			task.Wait();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
