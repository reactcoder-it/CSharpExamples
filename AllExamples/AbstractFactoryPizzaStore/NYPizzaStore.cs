/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 10:13
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of NYPizzaStore.
	/// </summary>
	public class NYPizzaStore : PizzaStore
	{
		public NYPizzaStore()
		{
		}
		
		protected override Pizza CreatePizza(string type)
		{
			Pizza pizza = null;
			IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
			
			switch (type)
			{
				case "cheese":
					pizza = new CheesePizza(ingredientFactory);
					pizza.Name = "New York Style Cheese Pizza";
					break;
				case "clam":
					pizza = new ClamPizza(ingredientFactory);
					pizza.Name = "New York Style Clam Pizza";
					break;
				case "pepperoni":
					pizza = new PepperoniPizza(ingredientFactory);
					pizza.Name = "New York Style Pepperoni Pizza";
					break;
			}
			return pizza;
		}
	}
}
