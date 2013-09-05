/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 04.08.2013
 * Time: 22:07
 */
using System;

namespace BinderPatternExample
{
	/// <summary>
	/// Description of DinnerMenuIterator.
	/// </summary>
	public class DinnerMenuIterator : IIterator
	{
		MenuItem[] items;
		int position = 0;
		
		public DinnerMenuIterator(MenuItem[] items) {
			this.items = items;
		}
		
		#region -= IIterator Members =-
		
		public Boolean HasNext() {
			if (position >= items.Length || items[position] == null) {
				return false;
			} else {
				return true;
			}
		}
		
		public Object Next() {
			MenuItem menuItem = items[position];
			position++;
			return menuItem;
		}
		
		#endregion
	}
}
