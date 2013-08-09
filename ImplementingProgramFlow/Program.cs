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
			
			int? c = null;
			int? z = null;
			int d = c ?? z ?? -1;
			Console.WriteLine(d);
			
			Console.WriteLine(GetValue(true));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		private static int GetValue(bool p)
		{
//			if (p)
//				return 1;
//			else
//				return 0;
			
			return p ? 1 : 0;
		}
	}
}