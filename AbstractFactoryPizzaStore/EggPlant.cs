/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 9:14
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of EggPlant.
	/// </summary>
	public class EggPlant : IVeggies
	{
		public EggPlant()
		{
		}
		
		public string toString()
		{
			return "Egg Plant";
		}
	}
}
