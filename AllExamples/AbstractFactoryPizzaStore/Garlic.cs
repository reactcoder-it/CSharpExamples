/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 9:13
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of Garlic.
	/// </summary>
	public class Garlic : IVeggies
	{
		public Garlic()
		{
		}
		
		public string toString()
		{
			return "Garlic";
		}
	}
}
