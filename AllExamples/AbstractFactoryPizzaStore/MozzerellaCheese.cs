/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 8:57
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of Mozzerella.
	/// </summary>
	public class MozzerellaCheese : ICheese
	{
		public MozzerellaCheese()
		{
		}
		
		public string toString()
		{
			return "Mozzerella Cheese";
		}
	}
}
