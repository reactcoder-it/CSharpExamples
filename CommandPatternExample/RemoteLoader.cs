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
			RemoteControl remoteControl = new RemoteControl();
			
			// Создание всех устройств
			Light livingRoomLight = new Light("Living Room");
			Light kitchenLight = new Light("Kitchen");
			CeilingFan ceilingFan = new CeilingFan("Living Room");
			GarageDoor garageDoor = new GarageDoor("");
			Stereo stereo = new Stereo("Living Room");
			
			// Создание команд:
			//   для управления освещением
			LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
			LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
			LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
			LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
			//   для управления потолочным вентилятором
			CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
			CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
			//   для управления дверью гаража
			GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
			GarageDoorCloseCommand garageDoorClose = new GarageDoorCloseCommand(garageDoor);
			//   для управления стереосистемой
			StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
			StereoOffCommand stereoOff = new StereoOffCommand(stereo);
			
			// Связываем команды с ячейками пульта
			remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
			remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
			remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
			remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);
			
			// Выводим список ячеек и связанных с ними команд
			Console.WriteLine(remoteControl.toString());
			
			// Имитируем нажатия кнопок
			for (int i=0; i<7; i++)
			{
				Console.WriteLine(remoteControl.OnButtonWasPushed(i));
				Console.WriteLine(remoteControl.OffButtonWasPushed(i));
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
