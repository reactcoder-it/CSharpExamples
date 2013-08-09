/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 9:00
 */
using System;
using System.Collections.Concurrent;

namespace UsingConcurrentQueue
{
	/// <summary>
	/// В данном примере используется класс ConcurrentQueue,
	/// который организует память типа FIFO и имеет методы Enqueue,
	/// для помещения элемента в коллекцию и TryDequeue - для извлечения
	/// из нее. Он также имеет метод TryPeek, который реализует интерфейс
	/// IEnumerable создающий снимок данных.
	/// </summary>
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
			queue.Enqueue(42);
			
			int result;
			if (queue.TryDequeue(out result))
				Console.WriteLine("Dequeued: {0}", result);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}