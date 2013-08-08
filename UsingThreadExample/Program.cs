/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 07.08.2013
 * Time: 10:49
 */
using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace UsingThreadExample
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static Task SleepAsyncA(int millisecondsTimeout)
		{
			return Task.Run(() => Thread.Sleep(millisecondsTimeout));
		}
		
		public static Task SleepAsyncB(int millisecondsTimeout)
		{
			TaskCompletionSource<bool> tcs = null;
			var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
			tcs = new TaskCompletionSource<bool>(t);
			t.Change(millisecondsTimeout, -1);
			return tcs.Task;
		}
	}
}