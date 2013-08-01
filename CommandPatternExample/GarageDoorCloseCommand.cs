/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 14:11
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of GarageDoorCloseCommand.
	/// </summary>
	public class GarageDoorCloseCommand : ICommand
	{
		GarageDoor garageDoor;
		
		public GarageDoorCloseCommand(GarageDoor garageDoor)
		{
			this.garageDoor = garageDoor;
		}
		
		public object Execute()
		{
			return garageDoor.Down();
		}
		
		public object Undo()
		{
			return garageDoor.Up();
		}
	}
}
