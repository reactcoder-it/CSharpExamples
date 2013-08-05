/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 15:49
 */
using System;

namespace ProxyPatternExample
{
	/// <summary>
	/// Description of IState.
	/// </summary>
	public interface IState
	{
		String InsertQuarter();
		String EjectQuarter();
		String TurnCrank();
		String Dispense();
	}
}
