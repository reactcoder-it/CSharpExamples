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
	/// Description of Spinach.
	/// </summary>
	public class Spinach : IVeggies
	{
		public Spinach()
		{
		}
		
		public string toString()
		{
			return "Spinach";
		}
	}
}
