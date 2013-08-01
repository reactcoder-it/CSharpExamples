/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 13:53
 */
using System;

namespace CommandPatternExample
{
	/// <summary>
	/// Description of RemoteLoader.
	/// </summary>
	public class RemoteLoader
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Hello World!");
			
			// Создание пульта
			RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();
			
			// Создание всех устройств
			CeilingFan ceilingFan = new CeilingFan("Living Room");
			
			// Создание команд:
			//   для управления вентилятором
			CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
			CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
			CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
			
			// Связываем команды с ячейками пульта
			remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
			remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);
			
			// Выводим список ячеек и связанных с ними команд
			Console.WriteLine(remoteControl.toString());
			
			// Имитируем нажатия кнопок
			Console.WriteLine(remoteControl.OnButtonWasPushed(0));
			Console.WriteLine(remoteControl.OffButtonWasPushed(0));
			Console.WriteLine(remoteControl.toString());
			Console.WriteLine(remoteControl.UndoButtonWasPushed());
			
			Console.WriteLine(remoteControl.OnButtonWasPushed(1));
			Console.WriteLine(remoteControl.toString());
			Console.WriteLine(remoteControl.UndoButtonWasPushed());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
