/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 13:40
 */
using System;
using System.Collections;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of Observable.
	/// </summary>
	public class Observable : IQuackObservable
	{
		ArrayList observers = new ArrayList();
		IQuackObservable duck;
		
		public Observable(IQuackObservable duck) {
			this.duck = duck;
		}
		
		public void RegisterObserver(IObserver observer) {
			observers.Add(observer);
		}
		
		public void NotifyObservers() {
			foreach (IObserver observer in observers) {
				observer.Update(duck);
			}
		}
	}
}
