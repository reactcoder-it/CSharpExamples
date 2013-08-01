/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 13:49
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of StereoOffCommand.
	/// </summary>
	public class StereoOffCommand : ICommand
	{
		Stereo stereo;
		
		public StereoOffCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}
		
		public object Execute()
		{
			return stereo.Off();
		}
		
		public object Undo()
		{
			return null;
		}
	}
}
