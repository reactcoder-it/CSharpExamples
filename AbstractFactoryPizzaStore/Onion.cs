/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 9:10
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of Onion.
	/// </summary>
	public class Onion : IVeggies
	{
		public Onion()
		{
		}
		
		public string toString()
		{
			return "Onion";
		}
	}
}
