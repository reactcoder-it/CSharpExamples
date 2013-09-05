/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 9:07
 */
using System;
using System.Collections.Concurrent;

namespace UsingConcurrentDictionary
{
	/// <summary>
	/// В данном примере используется класс ConcurrentDictionary,
	/// который сохраняет пары ключ-значение потоко-безопасным образом и
	/// имеет методы для добавления и удаления элементов, а также
	/// обновления элемента, если он существует.
	/// </summary>
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// Создание объекта ConcurrentDictionary
			var dict = new ConcurrentDictionary<String, int>();
			
			// Попытка добавить элемент [k1;42]
			if (dict.TryAdd("k1", 42))
				Console.WriteLine("Added");
			
			// Обновление значения элемента [k1;42] на [k1;21]
			if (dict.TryUpdate("k1", 21, 42))
				Console.WriteLine("42 updated to 21");
			
			dict["k1"] = 42; // безоговорочная перезапись значения k1
			
			// Добавление или обновление элемента (если существует)
			int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
			
			// Получение значения k2 (если его не существует - добавление в коллекцию
			int r2 = dict.GetOrAdd("k2", 3);
			
			Console.WriteLine(r1);
			Console.WriteLine(r2);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}