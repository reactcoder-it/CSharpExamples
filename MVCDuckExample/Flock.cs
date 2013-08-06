/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 13:22
 */
using System;
using System.Collections;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of Flock.
	/// </summary>
	public class Flock : IQuackable
	{
		ArrayList quackers = new ArrayList();
		
		public void Add(IQuackable quacker) {
			quackers.Add(quacker);
		}
		
		public void Quack() {
			foreach (IQuackable quacker in quackers) {
				quacker.Quack();
			}
		}
	}
}
