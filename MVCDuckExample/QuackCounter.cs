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
		Observable observable;
		
		public QuackCounter(IQuackable duck) {
			this.duck = duck;
			observable = new Observable(this);
		}
		
		public void Quack() {
			duck.Quack();
			numberOfQuacks++;
			NotifyObservers();
		}
		
		public static int GetQuacks() {
			return numberOfQuacks;
		}
		
		public void RegisterObserver(IObserver observer) {
			observable.RegisterObserver(observer);
		}
		
		public void NotifyObservers() {
			observable.NotifyObservers();
		}
	}
}
