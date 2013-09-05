/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 9:01
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of FreshClams.
	/// </summary>
	public class FreshClams : IClams
	{
		public FreshClams()
		{
		}
		
		public string toString()
		{
			return "Fresh Clams";
		}
	}
}
