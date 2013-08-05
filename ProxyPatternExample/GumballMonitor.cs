/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 05.08.2013
 * Time: 16:06
 */
using System;
using System.Text;

namespace ProxyPatternExample
{
	/// <summary>
	/// Description of GumballMonitor.
	/// </summary>
	public class GumballMonitor
	{
		GumballMachine machine;
		
		public GumballMonitor(GumballMachine machine) {
			this.machine = machine;
		}
		
		public String Report() {
			StringBuilder sb = new StringBuilder();
			
			sb.Append("Расположение аппарата: " + machine.Location + "\n");
			sb.Append("Текущее содержимое: " + machine.Count + "\n");
			sb.Append("Текущее состояние: " + machine.StateOfMachine + "\n");
			
			return sb.ToString();
		}
	}
}
