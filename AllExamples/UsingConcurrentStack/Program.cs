/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 8:51
 */
using System;
using System.Collections.Concurrent;

namespace UsingConcurrentStack
{
	/// <summary>
	/// В данном примере используется класс ConcurrentStack,
	/// который имеет два важных метода Push и TryPop. Push
	/// используется для добавления элементов в стек, а TryPop
	/// пытается получить элемент из стека. Но данный метод не
	/// гарантирует, что элемент будет получен из стека, поскольку
	/// множество потоков может получить доступ к вашей коллекции
	/// в одно и то же время.
	/// </summary>
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			ConcurrentStack<int> stack = new ConcurrentStack<int>();
			stack.Push(42);
			
			int result;
			if (stack.TryPop(out result))
				Console.WriteLine("Popped: {0}", result);
			
			stack.PushRange(new int[] { 1, 2, 3 });
			
			int[] values = new int[2];
			stack.TryPopRange(values);
			
			foreach (int i in values)
				Console.WriteLine(i);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}