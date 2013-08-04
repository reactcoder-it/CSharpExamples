/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 04.08.2013
 * Time: 9:40
 */
using System;
using System.Text;

namespace BinderPatternExample
{
	/// <summary>
	/// Description of Waitress.
	/// </summary>
	public class Waitress
	{
		IMenu pancakeHouseMenu;
		IMenu dinnerMenu;
		IMenu cafeMenu;
		
		public Waitress(IMenu pancakeHouseMenu, IMenu dinnerMenu, IMenu cafeMenu) {
			this.pancakeHouseMenu = pancakeHouseMenu;
			this.dinnerMenu = dinnerMenu;
			this.cafeMenu = cafeMenu;
		}
		
		public String PrintMenu() {
			StringBuilder sb = new StringBuilder();
			
			IIterator pancakeIterator = pancakeHouseMenu.CreateIterator();
			IIterator dinnerIterator = dinnerMenu.CreateIterator();
			IIterator cafeIterator = cafeMenu.CreateIterator();
			
			sb.Append("MENU\n----\nBREAKFAST\n");
			sb.Append(PrintMenu(pancakeIterator));
			sb.Append("\nLUNCH\n");
			sb.Append(PrintMenu(dinnerIterator));
			sb.Append("\nDINNER\n");
			sb.Append(PrintMenu(cafeIterator));
			
			return sb.ToString();
		}
		
		public String PrintMenu(IIterator iterator) {
			StringBuilder sb = new StringBuilder();
			while (iterator.HasNext()) {
				MenuItem menuItem = (MenuItem)iterator.Next();
				
				sb.Append(menuItem.Name + ", ");
				sb.Append(menuItem.Price + " -- ");
				sb.Append(menuItem.Description + "\n");
			}
			return sb.ToString();
		}
	}
}
