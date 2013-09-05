/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 11.08.2013
 * Time: 18:23
 */
using System;

namespace ExceptionHandling
{
	/// <summary>
	/// Description of InspectingException.
	/// </summary>
	public class InspectingException
	{
		public static void Main(string[] args)
		{
			try
			{
				int i = ReadAndParse();
				Console.WriteLine("Parsed: {0}", i);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Message: {0}", ex.Message);
				Console.WriteLine("StackTrace: {0}", ex.StackTrace);
				Console.WriteLine("HelpLink: {0}", ex.HelpLink);
				Console.WriteLine("InnerException: {0}", ex.InnerException);
				Console.WriteLine("TargetSite: {0}", ex.TargetSite);
				Console.WriteLine("Source: {0}", ex.Source);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int ReadAndParse()
		{
			String s = Console.ReadLine();
			int i = int.Parse(s);
			return i;
		}
	}
}
