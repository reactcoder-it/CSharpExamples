/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 9:22
 */
using System;
using System.Text;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of PepperoniPizza.
	/// </summary>
	public class PepperoniPizza : Pizza
	{
		IPizzaIngredientFactory ingredientFactory;
		
		public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}
		
		public override string Prepare()
		{
			dough = ingredientFactory.CreateDough();
			sauce = ingredientFactory.CreateSauce();
			cheese = ingredientFactory.CreateCheese();
			pepperoni = ingredientFactory.CreatePepperoni();
			
			StringBuilder sb = new StringBuilder();
			sb.Append("Preparing " + Name + "\n");
			sb.Append(dough.toString() + "\n");
			sb.Append(sauce.toString() + "\n");
			sb.Append(cheese.toString() + "\n");
			sb.Append(pepperoni.toString());
			
			return sb.ToString();
		}
	}
}
