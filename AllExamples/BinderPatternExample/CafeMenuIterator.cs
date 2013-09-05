/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 04.08.2013
 * Time: 22:19
 */
using System;
using System.Collections;

namespace BinderPatternExample
{
	/// <summary>
	/// Description of CafeMenuIterator.
	/// </summary>
	public class CafeMenuIterator : IIterator
	{
		Hashtable menuItems = new Hashtable();
		int position = 1;
		
		public CafeMenuIterator(Hashtable menuItems) {
			this.menuItems = menuItems;
		}
		
		#region -= IIterator Members =-
		
		public Boolean HasNext() {
			return position <= menuItems.Count ? true : false;
		}
		
		public Object Next() {
			MenuItem menuItem = (MenuItem)menuItems[position];
			position++;
			return menuItem;
		}
		
		#endregion
	}
}
