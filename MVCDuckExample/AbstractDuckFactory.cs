/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 13:11
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of AbstractDuckFactory.
	/// </summary>
	public abstract class AbstractDuckFactory
	{
		public abstract IQuackable CreateMallardDuck();
		public abstract IQuackable CreateRedheadDuck();
		public abstract IQuackable CreateDuckCall();
		public abstract IQuackable CreateRubberDuck();
	}
}
