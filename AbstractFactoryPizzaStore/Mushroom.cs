/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 9:12
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of Mushroom.
	/// </summary>
	public class Mushroom : IVeggies
	{
		public Mushroom()
		{
		}
		
		public string toString()
		{
			return "Mushroom";
		}
	}
}
