/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 13:25
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of NoCommand.
	/// </summary>
	public class NoCommand : ICommand
	{
		public NoCommand()
		{
		}
		
		public object Execute()
		{
			return "NoCommand";
		}
	}
}
