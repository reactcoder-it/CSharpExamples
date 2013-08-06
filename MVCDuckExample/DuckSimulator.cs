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
		public void Simulate(AbstractDuckFactory duckFactory) {
			IQuackable mallardDuck = duckFactory.CreateMallardDuck();
			IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
			IQuackable duckCall = duckFactory.CreateDuckCall();
			IQuackable rubberDuck = duckFactory.CreateRubberDuck();
			IQuackable gooseDuck = new GooseAdapter(new Goose());
			
			Console.WriteLine("\nDuck Simulator: With Goose Adapter");
			
			Simulate(mallardDuck);
			Simulate(redheadDuck);
			Simulate(duckCall);
			Simulate(rubberDuck);
			Simulate(gooseDuck);
			
			Console.WriteLine("The ducks quacked " + QuackCounter.GetQuacks() + " times");
		}
		
		public void Simulate(IQuackable duck) {
			duck.Quack();
		}
	}
}
