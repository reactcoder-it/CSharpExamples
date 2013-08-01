/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 13:36
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of Stereo.
	/// </summary>
	public class Stereo
	{
		string location;
		
		public Stereo(string location)
		{
			this.location = location;
		}
		
		public string On()
		{
			return location + " stereo is on";
		}
		
		public string Off()
		{
			return location + " stereo is off";
		}

		public string SetCD() 
		{
			return location + " stereo is set for CD input";
		}
		
		public string SetDVD() 
		{
			return location + " stereo is set for DVD input";
		}

		public string SetRadio() 
		{
			return location + " stereo is set for Radio";
		}

		public string SetVolume(int volume) 
		{
			// code to set the volume
			// valid range: 1-11 (after all 11 is better than 10, right?)
			return location + " stereo volume set to " + volume;
		}
	}
}
