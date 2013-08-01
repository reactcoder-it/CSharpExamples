/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 8:21
 */
using System;

namespace AbstractFactoryPizzaStore
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			PizzaStore nyStore = new NYPizzaStore();
			Pizza pizza = nyStore.OrderPizza("cheese");
			Console.WriteLine(pizza.Prepare());
			Console.WriteLine(pizza.Bake());
			Console.WriteLine(pizza.Cut());
			Console.WriteLine(pizza.Box());
			Console.WriteLine(pizza.Name + " готова...");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}