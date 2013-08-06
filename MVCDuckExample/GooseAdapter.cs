/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 12:54
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of GooseAdapter.
	/// </summary>
	public class GooseAdapter : IQuackable
	{
		Goose goose;
		
		public GooseAdapter(Goose goose) {
			this.goose = goose;
		}
		
		public void Quack() {
			goose.Honk();
		}
	}
}
