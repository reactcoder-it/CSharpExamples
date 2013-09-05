/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 11:33
 */
using System;
using System.Text;

namespace StatePatternExample
{
	/// <summary>
	/// Description of GumballMachineStart.
	/// </summary>
	public class GumballMachineStart
	{
		#region -= Members =-
		const int SOLD_OUT = 0;
		const int NO_QUARTER = 1;
		const int HAS_QUARTER = 2;
		const int SOLD = 3;
		
		int count = 0;
		int state = SOLD_OUT;
		#endregion
		
		public GumballMachineStart(int count) {
			this.count = count;
			if (count > 0) {
				state = NO_QUARTER;
			}
		}
		
		public String InsertQuarter() {
			String insertResponse = "";
			switch (state) {
				case HAS_QUARTER:
					insertResponse = "You can't insert another quarter";
					break;
				case NO_QUARTER:
					state = HAS_QUARTER;
					insertResponse = "You inserted a quarter";
					break;
				case SOLD_OUT:
					insertResponse = "You can't insert a quarter, the machine is sold out";
					break;
				case SOLD:
					insertResponse = "Please wait, we're already giving you a gumball";
					break;
				default:
					insertResponse = "Kick the machine and then call BR549 cause it ain't workin";
					break;
			}
			return insertResponse;
		}
		
		public String EjectQuarter() {
			String ejectResponse = "";
			switch (state) {
				case HAS_QUARTER:
					ejectResponse = "Quarter returned";
					state = NO_QUARTER;
					break;
				case NO_QUARTER:
					ejectResponse = "You haven't inserted a quarter";
					break;
				case SOLD_OUT:
					ejectResponse = "You can't eject, you haven't inserted a quarter yet";
					break;
				case SOLD:
					ejectResponse = "Sorry, you already turned the crank";
					break;
				default:
					ejectResponse = "Kick the machine and then call BR549 cause it ain't workin";
					break;
			}
			return ejectResponse;
		}
		
		public String TurnCrank() {
			String turnCrankResponse = "";
			switch (state) {
				case HAS_QUARTER:
					turnCrankResponse = "You turned...";
					state = SOLD;
					turnCrankResponse += Dispense();
					break;
				case NO_QUARTER:
					turnCrankResponse = "You turned but there's no quarter";
					break;
				case SOLD_OUT:
					turnCrankResponse = "You turned, but there are no gumballs";
					break;
				case SOLD:
					turnCrankResponse = "Turning twice doesn't get you another gumball!";
					break;
				default:
					turnCrankResponse = "Kick the machine and then call BR549 cause it ain't workin";
					break;
			}
			return turnCrankResponse;
		}
		
		public String Dispense() {
			String dispenseResponse = "";
			switch (state) {
				case HAS_QUARTER:
					dispenseResponse = "\nNo gumball dispensed";
					break;
				case NO_QUARTER:
					dispenseResponse = "\nYou need to pay first";
					break;
				case SOLD_OUT:
					dispenseResponse = "\nNo gumball dispensed";
					break;
				case SOLD:
					dispenseResponse = "\nA gumball comes rolling out the slot";
					count--;
					if (count == 0) {
						dispenseResponse = "\nNow out of gumballs!";
						state = SOLD_OUT;
					} else {
						state = NO_QUARTER;
					}
					break;
				default:
					dispenseResponse = "\nKick the machine and then call BR549 cause it ain't workin";
					break;
			}
			return dispenseResponse;
		}
		
		public void Refill(int newGumballs) {
			this.count = newGumballs;
			state = NO_QUARTER;
		}
		
		public String MachineState() {
			StringBuilder result = new StringBuilder();
			result.Append("\nMighty Gumball, Inc.");
			result.Append("\nC# Enabled Standing Gumball Model #2005\n");
			result.Append("Inventory: " + count + " gumball");
			if (count != 1) {
				result.Append("s");
			}
			result.Append("\nMachine is ");
			if (state == SOLD_OUT) {
				result.Append("sold out");
			} else if (state == NO_QUARTER) {
				result.Append("waiting for quarter");
			} else if (state == HAS_QUARTER) {
				result.Append("waiting for turn of crank");
			} else if (state == SOLD) {
				result.Append("delivering a gumball");
			}
			return result.ToString();
		}
	}
}
