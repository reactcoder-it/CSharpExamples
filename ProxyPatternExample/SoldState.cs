/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 16:21
 */
using System;

namespace ProxyPatternExample
{
	/// <summary>
	/// Description of SoldState.
	/// </summary>
	public class SoldState : IState
	{
		GumballMachine gumballMachine;
		IState noQuarterState;
		IState soldOutState;
		
		public SoldState(GumballMachine gumballMachine) {
			this.gumballMachine = gumballMachine;
			noQuarterState = new NoQuarterState(gumballMachine);
			soldOutState = new SoldOutState(gumballMachine);
		}
		
		public String InsertQuarter() {
			return "Пожалуйста подождите выдачи гумбола\n";
		}
		
		public String EjectQuarter() {
			return "Извините, вы уже повернули рычаг\n";
		}
		
		public String TurnCrank() {
			return "Двойное вращение не даст вам получение второго гумбола\n";
		}
		
		public String Dispense() {
			String outPut = gumballMachine.ReleaseBall();
			if (gumballMachine.Count > 0) {
				gumballMachine.StateOfMachine = noQuarterState;
			} else {
				gumballMachine.StateOfMachine = soldOutState;
				outPut += "Упс, нет больше гумболов\n";
			}
			return outPut;
		}
		
		public override string ToString()
		{
			//return string.Format("[SoldState GumballMachine={0}, NoQuarterState={1}, SoldOutState={2}]", gumballMachine, noQuarterState, soldOutState);
			return "поставка гумболов";
		}
	}
}
