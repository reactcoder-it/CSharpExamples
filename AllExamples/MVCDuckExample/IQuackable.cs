/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 12:31
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of Quackable.
	/// </summary>
	public interface IQuackable : IQuackObservable
	{
		void Quack();
	}
}
