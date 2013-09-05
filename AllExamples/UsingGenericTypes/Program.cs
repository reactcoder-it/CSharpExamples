/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 13.08.2013
 * Time: 14:13
 */
using System;

namespace UsingGenericTypes
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Product p = new Product();
			p.Price = 1000;
			Console.WriteLine(p.Discount());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}