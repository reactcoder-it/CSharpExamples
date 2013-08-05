/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 16:37
 */
using System;

namespace ProxyPatternExample
{
	/// <summary>
	/// Description of WinnerState.
	/// </summary>
	public class WinnerState : IState
	{
		GumballMachine gumballMachine;
		IState soldOutState;
		IState noQuarterState;
		
		public WinnerState(GumballMachine gumballMachine) {
			this.gumballMachine = gumballMachine;
			soldOutState = new SoldOutState(gumballMachine);
			noQuarterState = new NoQuarterState(gumballMachine);
		}
		
		public String InsertQuarter() {
			return "Пожалуйста возьмите Ваш гумбол\n";
		}
		
		public String EjectQuarter() {
			return "Извините, вы уже повернули рычаг\n";
		}
		
		public String TurnCrank() {
			return "Двойной поворот рычага не даст вам другой гумбол\n";
		}
		
		public String Dispense() {
			String outPut = gumballMachine.ReleaseBall();
			if (gumballMachine.Count > 0) {
				gumballMachine.StateOfMachine = noQuarterState;
			} else {
				gumballMachine.StateOfMachine = soldOutState;
				outPut += "Упс, гумболы закончились\n";
			}
			return outPut;
		}
		
		public override string ToString()
		{
			//return string.Format("[WinnerState GumballMachine={0}, SoldOutState={1}, NoQuarterState={2}]", gumballMachine, soldOutState, noQuarterState);
			return "выдача гумбола";
		}
	}
}
