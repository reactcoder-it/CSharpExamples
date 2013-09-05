/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 14:42
 */
using System;
using System.Text;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of RemoteControlWithUndo.
	/// </summary>
	public class RemoteControlWithUndo
	{
		ICommand[] onCommands;
		ICommand[] offCommands;
		ICommand undoCommand;
		
		public RemoteControlWithUndo()
		{
			onCommands = new ICommand[7];
			offCommands = new ICommand[7];
			
			ICommand noCommand = new NoCommand();
			for (int i=0; i<7; i++)
			{
				onCommands[i] = noCommand;
				offCommands[i] = noCommand;
			}
			undoCommand = noCommand;
		}
		
		public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
		{
			onCommands[slot] = onCommand;
			offCommands[slot] = offCommand;
		}
		
		public object OnButtonWasPushed(int slot)
		{
			object result = onCommands[slot].Execute();
			undoCommand = onCommands[slot];
			return result;
		}
		
		public object OffButtonWasPushed(int slot)
		{
			object result = offCommands[slot].Execute();
			undoCommand = offCommands[slot];
			return result;
		}
		
		public object UndoButtonWasPushed()
		{
			return undoCommand.Undo();
		}
		
		public String toString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("\n------ Remote Control ------\n");
			for (int i=0; i<onCommands.Length; i++)
			{
				sb.Append("[slot " + i + "] " + onCommands[i].GetType().Name + "\t\t\t" + offCommands[i].GetType().Name + "\n");
			}
			return sb.ToString();
		}
	}
}
