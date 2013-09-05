/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 15:48
 */
using System;

namespace ProxyPatternExample
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			GumballMachine gumballMachine = new GumballMachine("Aurora Park", 5);
			Console.WriteLine(gumballMachine.MachineStateHeader());
			
			Console.WriteLine(gumballMachine.InsertQuarter());
			Console.WriteLine(gumballMachine.TurnCrank());
			
			Console.WriteLine(gumballMachine.MachineStateHeader());
			Console.WriteLine(gumballMachine.InsertQuarter());
			Console.WriteLine(gumballMachine.TurnCrank());
			Console.WriteLine(gumballMachine.InsertQuarter());
			Console.WriteLine(gumballMachine.TurnCrank());
			
			Console.WriteLine(gumballMachine.MachineStateHeader());
			
			Console.WriteLine(gumballMachine.Refill(5));
			Console.WriteLine(gumballMachine.MachineStateHeader());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}