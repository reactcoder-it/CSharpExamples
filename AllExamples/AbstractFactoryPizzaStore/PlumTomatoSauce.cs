/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 8:54
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of PlumTomatoSauce.
	/// </summary>
	public class PlumTomatoSauce : ISauce
	{
		public PlumTomatoSauce()
		{
		}
		
		public string toString()
		{
			return "Plum Tomato Sauce";
		}
	}
}
