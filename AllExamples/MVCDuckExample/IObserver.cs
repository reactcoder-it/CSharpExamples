/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 13:44
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of IObserver.
	/// </summary>
	public interface IObserver
	{
		void Update(IQuackObservable duck);
	}
}
