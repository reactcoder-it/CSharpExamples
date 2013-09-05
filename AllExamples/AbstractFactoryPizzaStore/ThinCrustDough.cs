/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 8:53
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of ThinCrustDough.
	/// </summary>
	public class ThinCrustDough : IDough
	{
		public ThinCrustDough()
		{
		}
		
		public string toString()
		{
			return "Thin Crust Dough";
		}
	}
}
