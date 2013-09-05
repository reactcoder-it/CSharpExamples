/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 10:14
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of NYPizzaIngredientFactory.
	/// </summary>
	public class NYPizzaIngredientFactory : IPizzaIngredientFactory
	{
		public NYPizzaIngredientFactory()
		{
		}
		
		public IDough CreateDough()
		{
			return new ThinCrustDough();
		}
		
		public ISauce CreateSauce()
		{
			return new MarinaraSauce();
		}
		
		public ICheese CreateCheese()
		{
			return new ReggianoCheese();
		}
		
		public IVeggies[] CreateVeggies()
		{
			IVeggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
			return veggies;
		}
		
		public IPepperoni CreatePepperoni()
		{
			return new SlicedPepperoni();
		}
		
		public IClams CreateClam()
		{
			return new FreshClams();
		}
	}
}
