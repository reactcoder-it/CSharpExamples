/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 13.08.2013
 * Time: 19:59
 */
using System;

namespace ImplementingImplicitAndExplicitConversionOperator
{
	class Money
	{
		public decimal Amount { get; set; }
		
		public Money(decimal amount)
		{
			Amount = amount;
		}
		
		public static implicit operator decimal(Money money)
		{
			return money.Amount;
		}
		
		public static explicit operator int(Money money)
		{
			return (int)money.Amount;
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Money m = new Money(42.42M);
			decimal amount = m;
			int truncatedAmount = (int)m;
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}