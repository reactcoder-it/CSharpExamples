/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 14:03
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of CeilingFanOnCommand.
	/// </summary>
	public class CeilingFanOnCommand : ICommand
	{
		CeilingFan ceilingFan;
		
		public CeilingFanOnCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}
		
		public object Execute()
		{
			return ceilingFan.High();
		}
	}
}
