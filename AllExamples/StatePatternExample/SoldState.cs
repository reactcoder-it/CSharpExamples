/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 9:49
 */
using System;

namespace StatePatternExample
{
	/// <summary>
	/// Description of SoldState.
	/// </summary>
	public class SoldState : IState
	{
		#region -= Members =-
		GumballMachine gumballMachine;
		IState noQuarterState;
		IState soldOutState;
		#endregion
		
		#region -= Constructor =-
		public SoldState(GumballMachine gumballMachine) {
			this.gumballMachine = gumballMachine;
			noQuarterState = new NoQuarterState(gumballMachine);
			soldOutState = new SoldOutState(gumballMachine);
		}
		#endregion
		
		public String InsertQuarter() {
			return "Please wait, we're already giving you a gumball\n";
		}
		
		public String EjectQuarter() {
			return "Sorry, you already turned the crank\n";
		}
		
		public String TurnCrank() {
			return "Turning twice doesn't get you another gumball!\n";
		}
		
		public String Dispense() {
			String outPut = gumballMachine.ReleaseBall();
			if (gumballMachine.Count > 0) {
				gumballMachine.StateOfMachine = noQuarterState;
			} else {
				gumballMachine.StateOfMachine = soldOutState;
				outPut += "Oops, out of gumballs!\n";
			}
			return outPut;
		}
		
		#region -= ToString override =-
		public override string ToString()
		{
			//return string.Format("[SoldOutState GumballMachine={0}]", gumballMachine);
			return "delivering a gumball";
		}
		#endregion
	}
}
