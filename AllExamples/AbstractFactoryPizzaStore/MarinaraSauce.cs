/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 8:56
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of MarinaraSauce.
	/// </summary>
	public class MarinaraSauce : ISauce
	{
		public MarinaraSauce()
		{
		}
		
		public string toString()
		{
			return "Marinara Sauce";
		}
	}
}
