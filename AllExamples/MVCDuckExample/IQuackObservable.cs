/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 13:36
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of IQuackObservable.
	/// </summary>
	public interface IQuackObservable
	{
		void RegisterObserver(IObserver observer);
		void NotifyObservers();
	}
}
