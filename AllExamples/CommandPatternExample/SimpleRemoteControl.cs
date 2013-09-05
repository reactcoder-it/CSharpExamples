/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 12:48
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of SimpleRemoteControl.
	/// </summary>
	public class SimpleRemoteControl
	{
		ICommand slot;
		
		public SimpleRemoteControl()
		{
		}
		
		public object setCommand(ICommand command)
		{
			slot = command;
			return slot;
		}
		
		public object buttonWasPressed()
		{
			return slot.Execute();
		}
	}
}
