/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 10:11
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of PizzaStore.
	/// </summary>
	public abstract class PizzaStore
	{
		public PizzaStore()
		{
		}
		
		public Pizza OrderPizza(string type)
		{
			Pizza pizza;
			
			pizza = CreatePizza(type);
			
			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();
			
			return pizza;
		}
		
		protected abstract Pizza CreatePizza(string type);
	}
}
