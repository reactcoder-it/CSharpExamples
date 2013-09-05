/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 03.08.2013
 * Time: 19:49
 */
using System;

namespace BinderPatternExample
{
	public class MenuTestDrive
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
			DinnerMenu dinnerMenu = new DinnerMenu();
			CafeMenu cafeMenu = new CafeMenu();
			
			Waitress waitress = new Waitress(pancakeHouseMenu, dinnerMenu, cafeMenu);
			Console.WriteLine(waitress.PrintMenu());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}