/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 15.08.2013
 * Time: 8:09
 */
using System;
using System.Text;

namespace ManipulatingString
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			/* Не выгодный способ с точки зрения использования памяти,
 			 * поскольку переменна создает новый экземпляр строки в памяти
			 * чтоб добавить к нему еще часть строки */
//			String s = String.Empty;
//			for (int i=0; i<10000; i++)
//			{
//				s += "x";
//			}
//			Console.WriteLine(s);
			
			/* Здесь же все происходит во внутреннем буфере,
			 * в который просто добавляется часть строки */
			StringBuilder sb = new StringBuilder(String.Empty);
			
			for (int i=0; i<10000; i++)
			{
				sb.Append("x");
			}
			
			Console.WriteLine(sb.ToString());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}