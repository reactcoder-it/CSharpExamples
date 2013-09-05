/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 13.08.2013
 * Time: 14:14
 */
using System;

namespace UsingGenericTypes
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class MyClass<T> where T : class, new()
	{
		T MyProperty { get; set; }
		
		public MyClass()
		{
			MyProperty = new T();
		}
		
		public void MyGenericMethod<T>()
		{
			T defaultValue = default(T);
		}
	}
}
