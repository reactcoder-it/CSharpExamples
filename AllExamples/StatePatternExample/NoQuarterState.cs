/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 9:36
 */
using System;

namespace StatePatternExample
{
	/// <summary>
	/// Description of NoQuarterState.
	/// </summary>
	public class NoQuarterState : IState
	{
		GumballMachine gumballMachine;
		
		public NoQuarterState(GumballMachine gumballMachine) {
			this.gumballMachine = gumballMachine;
		}
		
		public String InsertQuarter() {
			return "You inserted a quarter";
			//gumballMachine.SetState(gumballMachine.GetHasQuarterState());
		}
		
		public String EjectQuarter() {
			return "You haven't inserted a quarter";
		}
		
		public String TurnCrank() {
			return "You turned, but there's no quarter";
		}
		
		public String Dispense() {
			return "You need to pay first";
		}
	}
}
