/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 9:15
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of BlackOlives.
	/// </summary>
	public class BlackOlives : IVeggies
	{
		public BlackOlives()
		{
		}
		
		public string toString()
		{
			return "BlackOlives";
		}
	}
}
