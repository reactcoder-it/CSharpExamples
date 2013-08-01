/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 9:08
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of SlicedPepperoni.
	/// </summary>
	public class SlicedPepperoni : IPepperoni
	{
		public SlicedPepperoni()
		{
		}
		
		public string toString()
		{
			return "Sliced Pepperoni";
		}
	}
}
