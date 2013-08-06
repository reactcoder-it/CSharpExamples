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
		Observable observable;
		
		public RedheadDuck() {
			observable = new Observable(this);
		}
		
		public void Quack() {
			Console.WriteLine("Quack");
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
