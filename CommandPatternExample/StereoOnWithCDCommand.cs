/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 13:38
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of StereoOnWithCDCommand.
	/// </summary>
	public class StereoOnWithCDCommand : ICommand
	{
		Stereo stereo;
		
		public StereoOnWithCDCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}
		
		public object Execute()
		{
			return stereo.On() + "\n" +
				stereo.SetCD() + "\n" +
				stereo.SetVolume(11);
		}
	}
}
