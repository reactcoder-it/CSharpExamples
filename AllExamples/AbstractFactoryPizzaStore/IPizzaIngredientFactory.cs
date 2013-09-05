/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 8:22
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of IPizzaIngredientFactory.
	/// </summary>
	public interface IPizzaIngredientFactory
	{
		IDough CreateDough();
		ISauce CreateSauce();
		ICheese CreateCheese();
		IVeggies[] CreateVeggies();
		IPepperoni CreatePepperoni();
		IClams CreateClam();
	}
}
