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
		Observable observable;
		
		public MallardDuck() {
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
