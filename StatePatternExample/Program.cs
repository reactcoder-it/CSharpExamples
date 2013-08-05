/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 8:06
 */
using System;

namespace StatePatternExample
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			GumballMachine gumballMachine = new GumballMachine(5);
			Console.WriteLine(gumballMachine);
			
			gumballMachine.InsertQuarter();
			gumballMachine.TurnCrank();
			Console.WriteLine(gumballMachine);
			
			gumballMachine.InsertQuarter();
			gumballMachine.EjectQuarter();
			gumballMachine.TurnCrank();
			Console.WriteLine(gumballMachine);
			
			gumballMachine.InsertQuarter();
			gumballMachine.TurnCrank();
			gumballMachine.InsertQuarter();
			gumballMachine.TurnCrank();
			gumballMachine.EjectQuarter();
			Console.WriteLine(gumballMachine);
			
			gumballMachine.InsertQuarter();
			gumballMachine.InsertQuarter();
			gumballMachine.TurnCrank();
			gumballMachine.InsertQuarter();
			gumballMachine.TurnCrank();
			gumballMachine.InsertQuarter();
			gumballMachine.TurnCrank();
			Console.WriteLine(gumballMachine);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}