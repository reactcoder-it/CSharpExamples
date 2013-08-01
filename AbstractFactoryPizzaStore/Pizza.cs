/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 9:02
 */
using System;

namespace AbstractFactoryPizzaStore
{
	/// <summary>
	/// Description of Pizza.
	/// </summary>
	public abstract class Pizza
	{
		#region -= Members =-
		private string name;
		protected IDough dough;
		protected ISauce sauce;
		protected IVeggies[] veggies;
		protected ICheese cheese;
		protected IPepperoni pepperoni;
		protected IClams clam;
		#endregion
		
		#region -= Name =-
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		#endregion
		
		#region -= Constructor =-
		public Pizza()
		{
		}
		#endregion
		
		public abstract string Prepare();
		
		public virtual string Bake()
		{
			return "Bake for 25 minutes at 350\n";
		}
		
		public virtual string Cut()
		{
			return "Cutting the pizza into diagonal slices\n";
		}
		
		public virtual string Box()
		{
			return "Place pizza in official PizzaStore box\n";
		}
	}
}
