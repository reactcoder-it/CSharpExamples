/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 12:44
 */
using System;

namespace CommandPatternExample
{
	class RemoteControlTest
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// Пульт
			SimpleRemoteControl remote = new SimpleRemoteControl();
			
			// Объекты управления: свет и дверь гаража.
			Light light = new Light("Kitchen");
			GarageDoor garageDoor = new GarageDoor("");
			
			// Команды пульта
			LightOnCommand lightOn = new LightOnCommand(light);
			GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);
			
			// Поскольку в пульте пока один слот,
			// то меняем команды динамически.
			remote.setCommand(lightOn);
			Console.WriteLine(remote.buttonWasPressed());
			remote.setCommand(garageOpen);
			Console.WriteLine(remote.buttonWasPressed());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}