/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 16:05
 */
using System;
using System.Text;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of MacroCommand.
	/// </summary>
	public class MacroCommand : ICommand
	{
		ICommand[] commands;
		
		public MacroCommand(ICommand[] commands) {
			this.commands = commands;
		}
		
		public object Execute() {
			StringBuilder sb = new StringBuilder();
			for (int i=0; i<commands.Length; i++) {
				sb.Append(commands[i].Execute() + "\n");
			}
			return sb.ToString();
		}
		
		public object Undo() {
			StringBuilder sb = new StringBuilder();
			for (int i=0; i<commands.Length; i++) {
				commands[i].Undo();
			}
			return sb.ToString();
		}
	}
}
