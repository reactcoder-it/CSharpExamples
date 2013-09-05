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
		int speed;
		
		public const int HIGH = 3;
		public const int MEDIUM = 2;
		public const int LOW = 1;
		public const int OFF = 0;
		
		public CeilingFan(string location)
		{
			this.location = location;
			speed = OFF;
		}
		
		public string High()
		{
			speed = HIGH;
			return location + " ceiling fan is on high";
		}
		
		public string Medium()
		{
			speed = MEDIUM;
			return location + " ceiling fan is on medium";
		}
		
		public string Low()
		{
			speed = LOW;
			return location + " ceiling fan is on low";
		}
		
		public string Off()
		{
			speed = LOW;
			return location + " ceiling fan is off";
		}
		
		public int GetSpeed()
		{
			return speed;
		}
	}
}
