/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 03.08.2013
 * Time: 19:56
 */
using System;

namespace BinderPatternExample
{
	/// <summary>
	/// Description of MenuItem.
	/// </summary>
	public class MenuItem
	{
		String name;
		String description;
		Boolean vegetarian;
		Double price;
		
		public String Name {
			get { return name; }
			set { name = value; }
		}
		
		public String Description {
			get { return description; }
			set { description = value; }
		}
		
		public Boolean IsVegetarian {
			get { return vegetarian; }
			set { vegetarian = value; }
		}
		
		public Double Price {
			get { return price; }
			set { price = value; }
		}
		
		public MenuItem(String name, String description, Boolean vegetarian, Double price) {
			this.name = name;
			this.description = description;
			this.vegetarian = vegetarian;
			this.price = price;
		}
	}
}
