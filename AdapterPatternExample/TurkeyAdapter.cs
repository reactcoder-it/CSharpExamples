/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 16:37
 */
using System;

namespace AdapterPatternExample
{
	/// <summary>
	/// Description of TurkeyAdapter.
	/// </summary>
	public class TurkeyAdapter : IDuck
	{
		ITurkey turkey;
		
		public TurkeyAdapter(ITurkey turkey)
		{
			this.turkey = turkey;
		}
		
		public void Quack()
		{
			this.turkey.Gobble();
		}
		
		public void Fly()
		{
			for (int i=0; i<5; i++)
			{
				this.turkey.Fly();
			}
		}
	}
}
