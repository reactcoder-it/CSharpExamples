/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 16:09
 */
using System;

namespace ProxyPatternExample
{
	/// <summary>
	/// Description of HasQuarterState.
	/// </summary>
	public class HasQuarterState : IState
	{
		GumballMachine gumballMachine;
		Random randomWinner = new Random(DateTime.Now.Millisecond);
		
		public HasQuarterState(GumballMachine gumballMachine) {
			this.gumballMachine = gumballMachine;
		}
		
		public String InsertQuarter() {
			return "Вы не можете вставить другую монету\n";
		}
		
		public String EjectQuarter() {
			return "Монета возвращена";
		}
		
		public String TurnCrank() {
			String outPut = "Вращение...\n";
			
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
			outPut += "Гумболы не выданы\n";
			return outPut;
		}
		
		public override string ToString()
		{
			//return string.Format("[HasQuarterState GumballMachine={0}, RandomWinner={1}]", gumballMachine, randomWinner);
			return "ожидание вращения рычага";
		}
	}
}
