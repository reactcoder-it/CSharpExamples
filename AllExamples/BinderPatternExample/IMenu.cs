/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 04.08.2013
 * Time: 21:54
 */
using System;

namespace BinderPatternExample
{
	/// <summary>
	/// Description of IMenu.
	/// </summary>
	public interface IMenu
	{
		IIterator CreateIterator();
	}
}
