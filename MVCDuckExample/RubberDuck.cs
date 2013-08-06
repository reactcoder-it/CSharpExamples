/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 12:34
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of RubberDuck.
	/// </summary>
	public class RubberDuck : IQuackable
	{
		public RubberDuck() {
		}
		
		public void Quack() {
			Console.WriteLine("Squeak");
		}
	}
}
