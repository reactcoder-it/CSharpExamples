/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 14.08.2013
 * Time: 11:32
 */
using System;

namespace CreatingAndUsingBaseClasses
{
	class Base
	{
//		public void Execute()
//		{
//			Console.WriteLine("Base.Execute");
//		}
		
		public virtual void Execute()
		{
			Console.WriteLine("Base.Execute");
		}
	}
	
	class Derived : Base
	{
//		public new void Execute()
//		{
//			Console.WriteLine("Derived.Execute");
//		}
		
		public override void Execute()
		{
			//base.Execute();
			Console.WriteLine("Derived.Execute");
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Base b = new Base();
			b.Execute();
			b = new Derived();
			b.Execute();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}