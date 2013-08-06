/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 12:33
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of DuckCall.
	/// </summary>
	public class DuckCall : IQuackable
	{
		Observable observable;
		
		public DuckCall() {
			observable = new Observable(this);
		}
		
		public void Quack() {
			Console.WriteLine("Kwak");
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
