/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 10:27
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of ChicagoPizzaStore.
	/// </summary>
	public class ChicagoPizzaStore : PizzaStore
	{
		public ChicagoPizzaStore()
		{
		}
		
		protected override Pizza CreatePizza(string type)
		{
			Pizza pizza = null;
			IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
			
			switch (type)
			{
				case "cheese":
					pizza = new CheesePizza(ingredientFactory);
					pizza.Name = "Chicago Style Cheese Pizza";
					break;
				case "clam":
					pizza = new ClamPizza(ingredientFactory);
					pizza.Name = "Chicago Style Clam Pizza";
					break;
				case "pepperoni":
					pizza = new PepperoniPizza(ingredientFactory);
					pizza.Name = "Chicago Style Pepperoni Pizza";
					break;
			}
			return pizza;
		}
	}
}
