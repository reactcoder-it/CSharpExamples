/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 04.08.2013
 * Time: 21:47
 */
using System;

namespace BinderPatternExample
{
	/// <summary>
	/// Description of IIterator.
	/// </summary>
	public interface IIterator
	{
		Boolean HasNext();
		Object Next();
	}
}
