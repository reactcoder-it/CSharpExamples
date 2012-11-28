/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 27.11.2012
 * Time: 23:11
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
	class Program
	{
		public static void Main(string[] args)
		{
			Action<object> action = (object obj) =>
			{
				Console.WriteLine("Task={0}, obj={1}, Thread={2}", 
				                  Task.CurrentId, obj.ToString(), 
				                  Thread.CurrentThread.ManagedThreadId);
			};
			
			// Создаем задачу
			Task t1 = new Task(action, "alpha");
			
			// Создаем стартовую задачу
			Task t2 = Task.Factory.StartNew(action, "beta");
			
			// Останавливаем основной поток для демонстрации, что задача t2 запущена
			t2.Wait();
			
			// Запускаем задачу t1
			t1.Start();
			
			Console.WriteLine("t1 has been launched! (MainThread={0})", Thread.CurrentThread.ManagedThreadId);
			
			// Ждем когда задача завершится. Опционально вы можете использовать
			// Timeout или Cancellation token для уменьшения ситуаций, когда
			// задача может выполняться очень долго.
			t1.Wait();
			
			// Создаем новую задачу
			Task t3 = new Task(action, "gamma");
			
			// Запускаем ее синхронно
			t3.RunSynchronously();
			
			// Хотя задача была выполнена синхронно, хорошо будет ожидание ее,
			// за исключение потенциально брошенной задачи.
			t3.Wait();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}