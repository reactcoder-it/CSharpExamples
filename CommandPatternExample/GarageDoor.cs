/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 13:00
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of GarageDoor.
	/// </summary>
	public class GarageDoor
	{
		string location;
		
		public GarageDoor(string location)
		{
			this.location = location;
		}
		
		public string Up()
		{
			return "Garage door is up";
		}
		
		public string Down()
		{
			return "Garage door is down";
		}
		
		public string Stop()
		{
			return "Garage door movement is stopped";
		}
		
		public string LightOn()
		{
			return "Garage door light is on";
		}
		
		public string LightOff()
		{
			return "Garage door light is off";
		}
	}
}
