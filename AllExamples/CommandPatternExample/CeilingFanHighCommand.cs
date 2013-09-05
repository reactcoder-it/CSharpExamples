/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 14:58
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of CeilingFanHighCommand.
	/// </summary>
	public class CeilingFanHighCommand : ICommand
	{
		CeilingFan ceilingFan;
		int prevSpeed;
		
		public CeilingFanHighCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}
		
		public object Execute()
		{
			prevSpeed = ceilingFan.GetSpeed();
			return ceilingFan.High();
		}
		
		public object Undo()
		{
			if (prevSpeed == CeilingFan.HIGH) {
				return ceilingFan.High();
			} else if (prevSpeed == CeilingFan.MEDIUM) {
				return ceilingFan.Medium();
			} else if (prevSpeed == CeilingFan.LOW) {
				return ceilingFan.Low();
			} else {
				return ceilingFan.Off();
			}
		}
	}
}
