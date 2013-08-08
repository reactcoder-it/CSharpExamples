/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 07.08.2013
 * Time: 10:49
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UsingThreadExample
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Task<int> t = Task.Factory.StartNew(() =>
			{
	           	return 42;
			});
			
			t.ContinueWith((i) =>
			{
				Console.WriteLine("Cancelled");
			}, TaskContinuationOptions.OnlyOnCanceled);
			
			t.ContinueWith((i) =>
			{
				Console.WriteLine("Faulted");
			}, TaskContinuationOptions.OnlyOnFaulted);
			
			var completedTask = t.ContinueWith((i) =>
			{
				Console.WriteLine("Completed");
			}, TaskContinuationOptions.OnlyOnRanToCompletion);
			
			completedTask.Wait();
			
			Console.WriteLine("\n" + t.Result);
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}