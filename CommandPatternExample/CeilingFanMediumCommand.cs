/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 15:05
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of CeilingFanMediumCommand.
	/// </summary>
	public class CeilingFanMediumCommand : ICommand
	{
		CeilingFan ceilingFan;
		int prevSpeed;
		
		public CeilingFanMediumCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}
		
		public object Execute()
		{
			prevSpeed = ceilingFan.GetSpeed();
			return ceilingFan.Medium();
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
