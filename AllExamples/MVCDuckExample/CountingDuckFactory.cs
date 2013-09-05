/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 13:15
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of CountingDuckFactory.
	/// </summary>
	public class CountingDuckFactory : AbstractDuckFactory
	{
		public override IQuackable CreateMallardDuck() {
			return new QuackCounter(new MallardDuck());
		}
		
		public override IQuackable CreateRedheadDuck() {
			return new QuackCounter(new RedheadDuck());
		}
		
		public override IQuackable CreateDuckCall() {
			return new QuackCounter(new DuckCall());
		}
		
		public override IQuackable CreateRubberDuck() {
			return new QuackCounter(new RubberDuck());
		}
	}
}
