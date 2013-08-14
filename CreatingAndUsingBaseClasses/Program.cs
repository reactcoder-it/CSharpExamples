﻿/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 14.08.2013
 * Time: 11:32
 */
using System;
using System.Collections.Generic;

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
	
	abstract class Base2
	{
		public virtual void MethodWithImplementation()
		{
		}
		
		public abstract void AbstractMethod();
	}
	
	class Derived2 : Base2
	{
		public override void AbstractMethod()
		{
		}
	}
	
	class Order : IComparable
	{
		public DateTime Created { get; set; }
		
		public int CompareTo(object obj)
		{
			if (obj == null) return 1;
			
			Order o = obj as Order;
			
			if (o == null)
			{
				throw new ArgumentException("Object is not an Order");
			}
			
			return this.Created.CompareTo(o.Created);
		}
		
		public override string ToString()
		{
			return string.Format("[Order Created={0}]", Created);
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
			
			List<Order> orders = new List<Order>()
			{
				new Order { Created = new DateTime(2012, 12, 1) },
				new Order { Created = new DateTime(2012, 1, 6) },
				new Order { Created = new DateTime(2012, 7, 8) },
				new Order { Created = new DateTime(2012, 2, 20) },
			};
			
			Console.WriteLine("Before sorting");
			foreach (var order in orders) {
				Console.WriteLine(order);
			}
			
			orders.Sort();
			
			Console.WriteLine("After sorting");
			foreach (var order in orders) {
				Console.WriteLine(order);
			}
			
			List<int> numbers = new List<int> { 1, 2, 3, 5, 7, 9 };
			using (List<int>.Enumerator enumerator = numbers.GetEnumerator()) {
				while (enumerator.MoveNext()) Console.WriteLine(enumerator.Current);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}