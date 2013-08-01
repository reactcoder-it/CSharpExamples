/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 13:55
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of CeilingFan.
	/// </summary>
	public class CeilingFan
	{
		string location;
		int level;
		
		public const int HIGH = 2;
		public const int MEDIUM = 1;
		public const int LOW = 0;
		
		public CeilingFan(string location)
		{
			this.location = location;
		}
		
		public string High()
		{
			level = HIGH;
			return location + " ceiling fan is on high";
		}
		
		public string Medium()
		{
			level = MEDIUM;
			return location + " ceiling fan is on medium";
		}
		
		public string Low()
		{
			level = LOW;
			return location + " ceiling fan is on low";
		}
		
		public string Off()
		{
			level = LOW;
			return location + " ceiling fan is off";
		}
		
		public int GetSpeed()
		{
			return level;
		}
	}
}
