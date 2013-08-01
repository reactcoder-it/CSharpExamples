/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 13:02
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of GarageDoorOpenCommand.
	/// </summary>
	public class GarageDoorOpenCommand : ICommand
	{
		GarageDoor garageDoor;
		
		public GarageDoorOpenCommand(GarageDoor garageDoor)
		{
			this.garageDoor = garageDoor;
		}
		
		public object Execute()
		{
			return garageDoor.Up();
		}
	}
}
