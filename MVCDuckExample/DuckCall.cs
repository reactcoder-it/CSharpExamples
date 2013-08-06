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
		public DuckCall() {
		}
		
		public void Quack() {
			Console.WriteLine("Kwak");
		}
	}
}
