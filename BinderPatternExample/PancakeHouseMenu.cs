﻿/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 04.08.2013
 * Time: 22:00
 */
using System;
using System.Collections;

namespace BinderPatternExample
{
	/// <summary>
	/// Description of PancakeHouseMenu.
	/// </summary>
	public class PancakeHouseMenu : IMenu
	{
		ArrayList menuItems;
		
		public PancakeHouseMenu() {
			menuItems = new ArrayList();
			
			AddItem("K&B's Pancake Breakfast",
			        "Pancakes with scrambled eggs, and toast",
			        true,
			        2.99);
			AddItem("Regular Pancake Breakfast",
			        "Pancakes with fried eggs, and sausage",
			        false,
			        2.99);
			AddItem("Blueberry Pancakes",
			        "Pancakes made with fresh blueberries",
			        true,
			        3.49);
			AddItem("Waffles",
			        "Waffles, with your choice of blueberries or strawberries",
			        true,
			        3.59);
		}
		
		public void AddItem(String name, String description, Boolean isVegetarian, Double price) {
			MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);
			menuItems.Add(menuItem);
		}
		
		public IIterator CreateIterator() {
			return new PancakeHouseIterator(menuItems);
		}
	}
}
