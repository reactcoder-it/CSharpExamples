/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 16:36
 */
using System;

namespace AdapterPatternExample
{
	/// <summary>
	/// Description of WildTurkey.
	/// </summary>
	public class WildTurkey : ITurkey
	{
		public WildTurkey()
		{
		}
		
		public void Gobble()
		{
			Console.WriteLine("Gobble gobble");
		}
		
		public void Fly()
		{
			Console.WriteLine("I'm flying a short distance");
		}
	}
}
