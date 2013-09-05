/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 9:55
 */
using System;

namespace StatePatternExample
{
	/// <summary>
	/// Description of HasQuarterState.
	/// </summary>
	public class HasQuarterState : IState
	{
		#region -= Members =-
		GumballMachine gumballMachine;
		Random randomWinner = new Random(DateTime.Now.Millisecond);
		#endregion
		
		public HasQuarterState(GumballMachine gumballMachine) {
			this.gumballMachine = gumballMachine;
		}
		
		public String InsertQuarter() {
			return "You can't insert another quarter\n";
		}
		
		public String EjectQuarter() {
			return "QuarterReturned\n";
		}
		
		public String TurnCrank() {
			String outPut = "You turned...\n";
			int winner = randomWinner.Next(10);
			if (winner == 0 && gumballMachine.Count > 1) {
				gumballMachine.StateOfMachine = new WinnerState(gumballMachine);
			} else {
				gumballMachine.StateOfMachine = new SoldState(gumballMachine);
			}
			return outPut;
		}
		
		public String Dispense() {
			String outPut = gumballMachine.ReleaseBall();
			outPut += "No gumball dispensed\n";
			return outPut;
		}
		
		#region -= ToString override =-
		public override String ToString()
		{
			//return string.Format("[HasQuarterState GumballMachine={0}, RandomWinner={1}]", gumballMachine, randomWinner);
			return "waiting for turn of crank";
		}

		#endregion
	}
}
