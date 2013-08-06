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
	/// Description of MallardDuck.
	/// </summary>
	public class MallardDuck : IQuackable
	{
		public MallardDuck() {
		}
		
		public void Quack() {
			Console.WriteLine("Quack");
		}
	}
}
