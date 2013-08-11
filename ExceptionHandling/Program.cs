/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 11.08.2013
 * Time: 17:13
 */
using System;

namespace ExceptionHandling
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			String s = Console.ReadLine();
			//if (String.IsNullOrWhiteSpace(s)) break;
				
			try
			{
				int i = int.Parse(s);
			}
			catch (ArgumentNullException)
			{
				Console.WriteLine("You need to enter a value");
			}
			catch (FormatException)
			{
				Console.WriteLine("{0} is not valid number. Please try again", s);
			}
			finally
			{
				Console.WriteLine("Program complete.");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}