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
			Light livingRoomLight = new Light("Living Room");
			
			// Создание команд:
			//   для управления освещением
			LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
			LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
			
			// Связываем команды с ячейками пульта
			remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
			
			// Выводим список ячеек и связанных с ними команд
			Console.WriteLine(remoteControl.toString());
			
			// Имитируем нажатия кнопок
			Console.WriteLine(remoteControl.OnButtonWasPushed(0));
			Console.WriteLine(remoteControl.OffButtonWasPushed(0));
			Console.WriteLine(remoteControl.toString());
			Console.WriteLine(remoteControl.UndoButtonWasPushed());
			Console.WriteLine(remoteControl.OffButtonWasPushed(0));
			Console.WriteLine(remoteControl.OnButtonWasPushed(0));
			Console.WriteLine(remoteControl.toString());
			Console.WriteLine(remoteControl.UndoButtonWasPushed());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
