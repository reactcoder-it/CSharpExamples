/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 12:32
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of RedheadDuck.
	/// </summary>
	public class RedheadDuck : IQuackable
	{
		public RedheadDuck() {
		}
		
		public void Quack() {
			Console.WriteLine("Quack");
		}
	}
}
