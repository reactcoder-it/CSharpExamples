/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 10:02
 */
using System;

namespace StatePatternExample
{
	/// <summary>
	/// Description of WinnerState.
	/// </summary>
	public class WinnerState : IState
	{
		#region -= Members =-
		GumballMachine gumballMachine;
		IState soldOutState;
		IState noQuarterState;
		#endregion
		
		public WinnerState(GumballMachine gumballMachine) {
			this.gumballMachine = gumballMachine;
			soldOutState = new SoldOutState(gumballMachine);
			noQuarterState = new NoQuarterState(gumballMachine);
		}
		
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
			String outPut = "YOUR A WINNER! You get two gumballs for your quarter\n";
			outPut += gumballMachine.ReleaseBall();
			if (gumballMachine.Count == 0) {
				gumballMachine.StateOfMachine = soldOutState;
			} else {
				outPut += gumballMachine.ReleaseBall();
				if (gumballMachine.Count > 0) {
					gumballMachine.StateOfMachine = noQuarterState;
				} else {
					outPut += "Oops, out of gumballs!\n";
					gumballMachine.StateOfMachine = soldOutState;
				}
			}
			return outPut;
		}
		
		#region -= ToString override =-
		public override String ToString()
		{
			//return string.Format("[WinnerState GumballMachine={0}, SoldOutState={1}, NoQuarterState={2}]", gumballMachine, soldOutState, noQuarterState);
			return "";
		}

		#endregion
	}
}
