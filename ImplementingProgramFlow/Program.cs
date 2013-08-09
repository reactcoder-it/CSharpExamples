/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 09.08.2013
 * Time: 19:45
 */
using System;

namespace ImplementingProgramFlow
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			int? x = null;
			int y = x ?? -1;
			Console.WriteLine(y);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}