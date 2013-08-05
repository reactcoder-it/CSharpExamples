/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 9:43
 */
using System;

namespace StatePatternExample
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
			return "You can't insert a quarter, the machine is sold out\n";
		}
		
		public String EjectQuarter() {
			return "You can't eject, you haven's inserted a quarter yet\n";
		}
		
		public String TurnCrank() {
			return "Sorry, you already turned the crank\n";
		}
		
		public String Dispense() {
			String outOut = gumballMachine.ReleaseBall();
			outOut += "You turned, but there are no gumballs\n";
			return outOut;
		}
		
		#region -= ToString override =-
		public override string ToString()
		{
			//return string.Format("[SoldOutState GumballMachine={0}]", gumballMachine);
			return "sold out";
		}
		#endregion
	}
}
