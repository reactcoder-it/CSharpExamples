/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 8:07
 */
using System;

namespace StatePatternExample
{
	/// <summary>
	/// Description of GumballMachine.
	/// </summary>
	public class GumballMachine
	{
		const int SOLD_OUT = 0;
		const int NO_QUARTER = 1;
		const int HAS_QUARTER = 2;
		const int SOLD = 3;
		
		int state = SOLD_OUT;
		int count = 0;
		
		public GumballMachine(int count) {
			this.count = count;
			if (count > 0) {
				state = NO_QUARTER;
			}
		}
		
		public void InsertQuarter() {
			if (state == HAS_QUARTER) {
				Console.WriteLine("You can't insert another quarter");
			} else if (state == NO_QUARTER) {
				state = HAS_QUARTER;
				Console.WriteLine("You inserted a quarter");
			} else if (state == SOLD_OUT) {
				Console.WriteLine("You can't insert a quarter, the machine is sold out");
			} else if (state == SOLD) {
				Console.WriteLine("Please wait, we're already giving you a gumball");
			}
		}
		
		public void EjectQuarter() {
			if (state == HAS_QUARTER) {
				state = NO_QUARTER;
				Console.WriteLine("Quarter returned");
			} else if (state == NO_QUARTER) {
				Console.WriteLine("You haven't inserted a quarter");
			} else if (state == SOLD) {
				Console.WriteLine("Sorry, you already turned the crank");
			} else if (state == SOLD_OUT) {
				Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
			}
		}
		
		public void TurnCrank() {
			if (state == SOLD) {
				Console.WriteLine("Turning twice doesn't get you another gumball!");
			} else if (state == NO_QUARTER) {
				Console.WriteLine("You turned but there's no quarter");
			} else if (state == SOLD_OUT) {
				Console.WriteLine("You turned, but there are no gumballs");
			} else if (state == HAS_QUARTER) {
				state = NO_QUARTER;
				Console.WriteLine("You turned...");
				state = SOLD;
				Dispence();
			}
		}
		
		public void Dispence() {
			if (state == SOLD) {
				Console.WriteLine("A gumball comes rolling out the slot");
				count--;
				if (count == 0) {
					Console.WriteLine("Oops, out of gumballs!");
					state = SOLD_OUT;
				} else {
					state = NO_QUARTER;
				}
			} else if (state == NO_QUARTER) {
				Console.WriteLine("You need to pay first");
			} else if (state == SOLD_OUT) {
				Console.WriteLine("No gumball dispensed");
			} else if (state == HAS_QUARTER) {
				Console.WriteLine("No gumball dispensed");
			}
		}
		
		public override string ToString() {
			return string.Format("[GumballMachine State={0}, Count={1}]", state, count);
		}
	}
}
