/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 13.08.2013
 * Time: 16:00
 */
using System;

namespace UsingGenericTypes
{
	class Base
	{
		public virtual int MyMethod()
		{
			return 42;
		}
	}
	
	class Derived : Base
	{
		public sealed override int MyMethod()
		{
			return base.MyMethod() * 2;
		}
	}
	
	class Derived2 : Derived
	{
		// This line would give a compile error
		//public override int MyMethod() { return 1; }
	}
}
