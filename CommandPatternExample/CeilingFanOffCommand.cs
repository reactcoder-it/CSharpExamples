/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 14:01
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of CeilingFanOffCommand.
	/// </summary>
	public class CeilingFanOffCommand : ICommand
	{
		CeilingFan ceilingFan;
		
		public CeilingFanOffCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}
		
		public object Execute()
		{
			return ceilingFan.Off();
		}
		
		public object Undo()
		{
			return null;
		}
	}
}
