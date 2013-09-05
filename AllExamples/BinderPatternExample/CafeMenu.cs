/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 04.08.2013
 * Time: 22:23
 */
using System;
using System.Collections;

namespace BinderPatternExample
{
	/// <summary>
	/// Description of CafeMenu.
	/// </summary>
	public class CafeMenu : IMenu
	{
		Hashtable menuItems = new Hashtable();
		
		public CafeMenu() {
			AddItem("Veggie Burger and Fries",
			        "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
			        true,
			        3.99,
			        1);
			AddItem("Soup of the day",
			        "A cup of the soup of the day, with a side salad",
			        false,
			        3.69,
			        2);
			AddItem("Burrito",
			        "A large burrito, with whole pinto beans, salsa, guacamole",
			        true,
			        4.29,
			        3);
		}
		
		public void AddItem(String name, String description, Boolean isVegetarian, Double price, int index) {
			MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);
			menuItems.Add(index, menuItem);
		}
		
		#region -= Menu Members =-
		
		public IIterator CreateIterator() {
			return new CafeMenuIterator(menuItems);
		}
		
		#endregion
	}
}
