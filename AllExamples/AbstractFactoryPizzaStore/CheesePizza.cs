/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 9:19
 */
using System;
using System.Text;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of CheesePizza.
	/// </summary>
	public class CheesePizza : Pizza
	{
		IPizzaIngredientFactory ingredientFactory;
		
		public CheesePizza(IPizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}
		
		public override string Prepare()
		{
			dough = ingredientFactory.CreateDough();
			sauce = ingredientFactory.CreateSauce();
			cheese = ingredientFactory.CreateCheese();
			
			StringBuilder sb = new StringBuilder();
			sb.Append("Preparing " + Name + "\n");
			sb.Append(dough.toString() + "\n");
			sb.Append(sauce.toString() + "\n");
			sb.Append(cheese.toString());
			
			return sb.ToString();
		}
	}
}
