/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 14.08.2013
 * Time: 11:32
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

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
	
	class Person
	{
		public Person(string firstName, string lastName)
		{
		}
		
		public string FirstName { get; set; }
		public string LastName { get; set; }
		
		public override string ToString()
		{
			return string.Format("[Person FirstName={0}, LastName={1}]", FirstName, LastName);
		}
	}
	
	[Serializable]
	class Person2
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		
		[Conditional("CONDITION1"), Conditional("CONDITION2")]
		static void MyMethod()
		{
		}
	}
	
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	class MyMultipleUsageAttribute : Attribute
	{
	}
	
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
	class CompleteCustomAttribute : Attribute
	{
		public CompleteCustomAttribute(string description)
		{
			Description = description;
		}
		
		public string Description { get; set; }
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
			
			/* Проверка применения атрибута */
			if (!Attribute.IsDefined(typeof(Person), typeof(SerializableAttribute)))
				Console.WriteLine("Yes");
			if (Attribute.IsDefined(typeof(Person2), typeof(SerializableAttribute)))
				Console.WriteLine("Yes");
			
			/* Определение параметров аттрибута */
//			ConditionalAttribute conditionalAttribute = (ConditionalAttribute)Attribute.GetCustomAttribute(typeof(Person2), typeof(ConditionalAttribute));
//			string condition = conditionalAttribute.ConditionString;
//			Console.WriteLine(condition);
			
			/* Рефлексивное получение метода и выполнение его */
			int i = 42;
			MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo", new Type[] { typeof(int) });
			int result = (int)compareToMethod.Invoke(i, new Object[] { 41 });
			Console.WriteLine(i);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}