/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 10:21
 */
using System;
using System.Text;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of ClamPizza.
	/// </summary>
	public class ClamPizza : Pizza
	{
		IPizzaIngredientFactory ingredientFactory;
		
		public ClamPizza(IPizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}
		
		public override string Prepare()
		{
			dough = ingredientFactory.CreateDough();
			sauce = ingredientFactory.CreateSauce();
			cheese = ingredientFactory.CreateCheese();
			clam = ingredientFactory.CreateClam();
			
			StringBuilder sb = new StringBuilder();
			sb.Append("Preparing " + Name + "\n");
			sb.Append(dough.toString() + "\n");
			sb.Append(sauce.toString() + "\n");
			sb.Append(cheese.toString() + "\n");
			sb.Append(clam.toString());
			
			return sb.ToString();
		}
	}
}
