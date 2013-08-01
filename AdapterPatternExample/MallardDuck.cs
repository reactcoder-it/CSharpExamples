/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 16:34
 */
using System;

namespace AdapterPatternExample
{
	/// <summary>
	/// Description of MallardDuck.
	/// </summary>
	public class MallardDuck : IDuck
	{
		public MallardDuck()
		{
		}
		
		public void Quack()
		{
			Console.WriteLine("Quack");
		}
		
		public void Fly()
		{
			Console.WriteLine("I'm flying...");
		}
	}
}
