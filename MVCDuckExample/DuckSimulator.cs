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
			IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
			IQuackable duckCall = duckFactory.CreateDuckCall();
			IQuackable rubberDuck = duckFactory.CreateRubberDuck();
			IQuackable gooseDuck = new GooseAdapter(new Goose());
			
			Console.WriteLine("\nDuck Simulator: With Composite Flocks");
			
			Flock flockOfDucks = new Flock();
			flockOfDucks.Add(redheadDuck);
			flockOfDucks.Add(duckCall);
			flockOfDucks.Add(rubberDuck);
			flockOfDucks.Add(gooseDuck);
			
			Flock flockOfMallards = new Flock();
			IQuackable mallardOne = duckFactory.CreateMallardDuck();
			IQuackable mallardTwo = duckFactory.CreateMallardDuck();
			IQuackable mallardThree = duckFactory.CreateMallardDuck();
			IQuackable mallardFour = duckFactory.CreateMallardDuck();
			
			flockOfMallards.Add(mallardOne);
			flockOfMallards.Add(mallardTwo);
			flockOfMallards.Add(mallardThree);
			flockOfMallards.Add(mallardFour);
			
			flockOfDucks.Add(flockOfMallards);
			
			Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
			Simulate(flockOfDucks);
			
			Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
			Simulate(flockOfMallards);
			
			Console.WriteLine("The ducks quacked " + QuackCounter.GetQuacks() + " times");
		}
		
		public void Simulate(IQuackable duck) {
			duck.Quack();
		}
	}
}
