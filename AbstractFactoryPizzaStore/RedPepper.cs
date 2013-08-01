/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 9:11
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of RedPepper.
	/// </summary>
	public class RedPepper : IVeggies
	{
		public RedPepper()
		{
		}
		
		public string toString()
		{
			return "Red Pepper";
		}
	}
}
