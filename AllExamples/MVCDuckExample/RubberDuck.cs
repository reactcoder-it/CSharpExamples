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
		Observable observable;
		
		public RubberDuck() {
			observable = new Observable(this);
		}
		
		public void Quack() {
			Console.WriteLine("Squeak");
			NotifyObservers();
		}
		
		public void RegisterObserver(IObserver observer) {
			observable.RegisterObserver(observer);
		}
		
		public void NotifyObservers() {
			observable.NotifyObservers();
		}
	}
}
