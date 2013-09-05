/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 13:34
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of LightOffCommand.
	/// </summary>
	public class LightOffCommand : ICommand
	{
		Light light;
		
		public LightOffCommand(Light light)
		{
			this.light = light;
		}
		
		public object Execute()
		{
			return light.Off();
		}
		
		public object Undo()
		{
			return light.On();
		}
	}
}
