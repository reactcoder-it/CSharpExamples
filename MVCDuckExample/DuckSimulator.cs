/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 06.08.2013
 * Time: 12:34
 */
using System;

namespace MVCDuckExample
{
	/// <summary>
	/// Description of DuckSimulator.
	/// </summary>
	public class DuckSimulator
	{
		public void Simulate() {
			IQuackable mallardDuck = new MallardDuck();
			IQuackable redheadDuck = new RedheadDuck();
			IQuackable duckCall = new DuckCall();
			IQuackable rubberDuck = new RubberDuck();
			IQuackable gooseDuck = new GooseAdapter(new Goose());
			
			Console.WriteLine("\nDuck Simulator: With Goose Adapter");
			
			Simulate(mallardDuck);
			Simulate(redheadDuck);
			Simulate(duckCall);
			Simulate(rubberDuck);
			Simulate(gooseDuck);
		}
		
		public void Simulate(IQuackable duck) {
			duck.Quack();
		}
	}
}
