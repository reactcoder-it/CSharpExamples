/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 10:25
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of ChicagoPizzaIngredientFactory.
	/// </summary>
	public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
	{
		public ChicagoPizzaIngredientFactory()
		{
		}
		
		public IDough CreateDough()
		{
			return new ThickCrustDough();
		}
		
		public ISauce CreateSauce()
		{
			return new PlumTomatoSauce();
		}
		
		public ICheese CreateCheese()
		{
			return new MozzerellaCheese();
		}
		
		public IVeggies[] CreateVeggies()
		{
			IVeggies[] veggies = { new BlackOlives(), new Spinach(), new EggPlant() };
			return veggies;
		}
		
		public IPepperoni CreatePepperoni()
		{
			return new SlicedPepperoni();
		}
		
		public IClams CreateClam()
		{
			return new FrozenClams();
		}
	}
}
