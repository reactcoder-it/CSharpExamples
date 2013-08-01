/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 12:46
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of LightOnCommand.
	/// </summary>
	public class LightOnCommand : ICommand
	{
		Light light;
		
		public LightOnCommand(Light light)
		{
			this.light = light;
		}
		
		public object Execute()
		{
			return light.On();
		}
	}
}
