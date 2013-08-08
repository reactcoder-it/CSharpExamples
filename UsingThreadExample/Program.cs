/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 07.08.2013
 * Time: 10:49
 */
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UsingThreadExample
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Task<int>[] tasks = new Task<int>[3];
			
			tasks[0] = Task.Factory.StartNew(() => { Thread.Sleep(2000); return 1; });
			tasks[1] = Task.Factory.StartNew(() => { Thread.Sleep(1000); return 2; });
			tasks[2] = Task.Factory.StartNew(() => { Thread.Sleep(3000); return 3; });
			
			while (tasks.Length > 0)
			{
				int i = Task.WaitAny(tasks);
				Task<int> completedTask = tasks[i];
				
				Console.WriteLine(completedTask.Result);
				
				var temp = tasks.ToList();
				temp.RemoveAt(i);
				tasks = temp.ToArray();
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}