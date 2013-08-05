/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 16:33
 */
using System;

namespace ProxyPatternExample
{
	/// <summary>
	/// Description of SoldOutState.
	/// </summary>
	public class SoldOutState : IState
	{
		GumballMachine gumballMachine;
		
		public SoldOutState(GumballMachine gumballMachine) {
			this.gumballMachine = gumballMachine;
		}
		
		public String InsertQuarter() {
			return "Вы не можете вставить монету, машина пуста\n";
		}
		
		public String EjectQuarter() {
			return "Вы не можете достать монету, монета не вставлена в слот\n";
		}
		
		public String TurnCrank() {
			return "Извините, поворачивать рычаг бесполезно\n";
		}
		
		public String Dispense() {
			String outPut = gumballMachine.ReleaseBall();
			outPut += "Вы повернули, но гумболы закончились\n";
			return outPut;
		}
		
		public override string ToString()
		{
			//return string.Format("[SoldOutState GumballMachine={0}]", gumballMachine);
			return "распродано";
		}

	}
}
