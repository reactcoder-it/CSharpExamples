/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 8:51
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of ThickCrustDough.
	/// </summary>
	public class ThickCrustDough : IDough
	{
		public ThickCrustDough()
		{
		}
		
		public string toString()
		{
			return "Thick Crust Dough";
		}
	}
}
