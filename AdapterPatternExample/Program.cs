/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 16:32
 */
using System;

namespace AdapterPatternExample
{
	public class DuckTestDrive
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			MallardDuck duck = new MallardDuck();
			WildTurkey turkey = new WildTurkey();
			
			// Упаковка turkey в turkeyAdapter, после чего
			// turkey начинает выглядеть как Duck.
			IDuck turkeyAdapter = new TurkeyAdapter(turkey);
			
			Console.WriteLine("The Turkey says...");
			turkey.Gobble();
			turkey.Fly();
			
			Console.WriteLine("\nThe Duck says...");
			duck.Quack();
			duck.Fly();
			
			Console.WriteLine("\nThe TurkeyAdapter says...");
			turkeyAdapter.Quack();
			turkeyAdapter.Fly();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}