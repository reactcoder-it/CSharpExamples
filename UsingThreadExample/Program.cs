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
			
			Task<Int32[]> parent = Task.Factory.StartNew(() =>
			{
				var results = new Int32[3];
				
				new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
				new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
				new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();
				
				return results;
			});
			
			var finalTask = parent.ContinueWith(parentTask =>
			{
				foreach (int i in parentTask.Result)
					Console.WriteLine(i);
			});
			
			finalTask.Wait();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}