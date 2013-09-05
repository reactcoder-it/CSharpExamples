/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 9:35
 */
using System;

namespace StatePatternExample
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
