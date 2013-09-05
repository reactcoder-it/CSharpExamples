/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 8:58
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of ReggianoCheese.
	/// </summary>
	public class ReggianoCheese : ICheese
	{
		public ReggianoCheese()
		{
		}
		
		public string toString()
		{
			return "Reggiano Cheese";
		}
	}
}
