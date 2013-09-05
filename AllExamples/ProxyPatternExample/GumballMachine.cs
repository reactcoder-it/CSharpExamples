/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 15:48
 */
using System;
using System.Text;

namespace ProxyPatternExample
{
	/// <summary>
	/// Description of GumballMachine.
	/// </summary>
	public class GumballMachine
	{
		IState soldOutState;
		IState noQuarterState;
		IState hasQuarterState;
		IState soldState;
		IState state;
		
		String location;
		int count = 0;
		
		public String Location {
			get { return location; }
			set { location = value; }
		}
		
		public IState StateOfMachine {
			get { return state; }
			set { state = value; }
		}
		
		public int Count {
			get { return count; }
			set { count = value; }
		}
		
		public GumballMachine(String location, int numberOfGumballs) {
			this.soldOutState = new SoldOutState(this);
			this.noQuarterState = new NoQuarterState(this);
			this.hasQuarterState = new HasQuarterState(this);
			this.soldState = new SoldState(this);
			this.count = numberOfGumballs;
			this.location = location;
			if (numberOfGumballs > 0) {
				state = noQuarterState;
			} else {
				state = soldOutState;
			}
		}
		
		public String InsertQuarter() {
			return state.InsertQuarter();
		}
		
		public String EjectQuarter() {
			return state.EjectQuarter();
		}
		
		public String TurnCrank() {
			return state.TurnCrank() + state.Dispense();
		}
		
		public String ReleaseBall() {
			if (count != 0) {
				count--;
			}
			return "Гумбол вываливается в слот...\n";
		}
		
		public String Refill(int numberOfGumballs) {
			this.count += numberOfGumballs;
			state = noQuarterState;
			
			return "\nПополнение: было добавлено " + numberOfGumballs + " гумболов. " +
				"Количество гумболов: " + count + "\n";
		}
		
		public String MachineStateHeader() {
			StringBuilder result = new StringBuilder();
			result.Append("Mighty Gumball, Inc.");
			result.Append("\nC# Enabled Standing Gumball Model #2005\n");
			result.Append("Содержимое: " + count);
			if (count == 1) {
				result.Append(" гумбол");
			} else if (count == 2) {
				result.Append(" гумбола");
			} else {
				result.Append(" гумболов");
			}
			result.Append("\nМашина находится в состоянии " + state.ToString());
			return result.ToString();
		}
	}
}
