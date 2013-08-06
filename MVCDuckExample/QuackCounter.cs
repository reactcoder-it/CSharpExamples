/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 13:00
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of QuackCounter.
	/// </summary>
	public class QuackCounter : IQuackable
	{
		IQuackable duck;
		static int numberOfQuacks;
		
		public QuackCounter(IQuackable duck) {
			this.duck = duck;
		}
		
		public void Quack() {
			duck.Quack();
			numberOfQuacks++;
		}
		
		public static int GetQuacks() {
			return numberOfQuacks;
		}
	}
}
