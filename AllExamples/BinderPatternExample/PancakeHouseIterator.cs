/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 04.08.2013
 * Time: 21:56
 */
using System;
using System.Collections;

namespace BinderPatternExample
{
	/// <summary>
	/// Description of PancakeHouseIterator.
	/// </summary>
	public class PancakeHouseIterator : IIterator
	{
		ArrayList menuItems = new ArrayList();
		int position = 0;
		
		public PancakeHouseIterator(ArrayList menuItems) {
			this.menuItems = menuItems;
		}
		
		#region -= IIterator Members =-
		
		public Boolean HasNext() {
			if (position >= menuItems.Count || menuItems[position] == null) {
				return false;
			} else {
				return true;
			}
		}
		
		public Object Next() {
			MenuItem menuItem = (MenuItem)menuItems[position];
			position++;
			return menuItem;
		}
		
		#endregion
	}
}
