/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 13.08.2013
 * Time: 14:43
 */
using System;

namespace UsingGenericTypes
{
	/// <summary>
	/// Description of CreatingExtensionMethod.
	/// </summary>
	public class Product
	{
		public decimal Price { get; set; }
	}
	
	public static class MyExtensions
	{
		public static decimal Discount(this Product product)
		{
			return product.Price * .9M;
		}
	}
	
	public class Calculator
	{
		public decimal CalculateDiscount(Product p)
		{
			return p.Discount();
		}
	}
}
