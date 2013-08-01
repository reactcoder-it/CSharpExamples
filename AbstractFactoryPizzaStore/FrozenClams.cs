/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 9:00
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of FrozenClams.
	/// </summary>
	public class FrozenClams : IClams
	{
		public FrozenClams()
		{
		}
		
		public string toString()
		{
			return "Frozen Clams";
		}
	}
}
