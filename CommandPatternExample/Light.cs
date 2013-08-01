/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 12:53
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of Light.
	/// </summary>
	public class Light
	{
		string location;
		
		public Light(string location)
		{
			this.location = location;
		}
		
		public string On()
		{
			return location + " light is on";
		}
		
		public string Off()
		{
			return location + " light is off";
		}
	}
}
