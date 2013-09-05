/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 12:45
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of ICommand.
	/// </summary>
	public interface ICommand
	{
		object Execute();
		object Undo();
	}
}
