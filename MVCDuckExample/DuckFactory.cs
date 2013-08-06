/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 13:13
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of DuckFactory.
	/// </summary>
	public class DuckFactory : AbstractDuckFactory
	{
		public override IQuackable CreateMallardDuck() {
			return new MallardDuck();
		}
		
		public override IQuackable CreateRedheadDuck() {
			return new RedheadDuck();
		}
		
		public override IQuackable CreateDuckCall() {
			return new DuckCall();
		}
		
		public override IQuackable CreateRubberDuck() {
			return new RubberDuck();
		}
	}
}
