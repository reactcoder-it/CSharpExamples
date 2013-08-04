/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 03.08.2013
 * Time: 19:49
 */
using System;

namespace BinderPatternExample
{
	/// <summary>
	/// Description of MenuComponent.
	/// </summary>
	public abstract class MenuComponent
	{
		public MenuComponent() {
		}
		
		public void Add(MenuComponent menuComponent) {
			throw new NotSupportedException();
		}
		
		public void Remove(MenuComponent menuComponent) {
			throw new NotSupportedException();
		}
		
		public MenuComponent GetChild(int i) {
			throw new NotSupportedException();
		}
		
		public String GetName() {
			throw new NotSupportedException();
		}
		
		public String GetDescription() {
			throw new NotSupportedException();
		}
		
		public Double GetPrice() {
			throw new NotSupportedException();
		}
		
		public Boolean IsVegetarian() {
			throw new NotSupportedException();
		}
		
		public void Print() {
			throw new NotSupportedException();
		}
	}
}
