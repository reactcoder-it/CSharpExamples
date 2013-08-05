/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 16:29
 */
using System;

namespace ProxyPatternExample
{
	/// <summary>
	/// Description of NoQuarterState.
	/// </summary>
	public class NoQuarterState : IState
	{
		GumballMachine gumballMachine;
		IState hasQuarterState;
		
		public NoQuarterState(GumballMachine gumballMachine) {
			this.gumballMachine = gumballMachine;
			hasQuarterState = new HasQuarterState(gumballMachine);
		}
		
		public String InsertQuarter() {
			gumballMachine.StateOfMachine = hasQuarterState;
			return "Вы вставили монету\n";
		}
		
		public String EjectQuarter() {
			return "Монета не вставлена\n";
		}
		
		public String TurnCrank() {
			return "Вы повернули, но монеты нет\n";
		}
		
		public String Dispense() {
			String outPut = gumballMachine.ReleaseBall();
			outPut += "Сначала вы должны оплатить\n";
			return outPut;
		}
		
		public override String ToString()
		{
			//reurn string.Format("[NoQuarterState GumballMachine={0}, HasQuarterState={1}]", gumballMachine, hasQuarterState);
			return "ожидание монеты";
		}
	}
}
