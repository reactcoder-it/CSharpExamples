/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 13:58
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of Quackologist.
	/// </summary>
	public class Quackologist : IObserver
	{
		public Quackologist() {
		}
		
		public void Update(IQuackObservable duck) {
			Console.WriteLine("Quackologist: " + duck.GetType().Name + " just quacked.");
		}
	}
}
