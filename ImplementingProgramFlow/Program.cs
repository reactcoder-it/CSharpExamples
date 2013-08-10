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
			
			int[] values = { 1, 2, 3, 4, 5, 6 };
			for (int index = 0; index < values.Length; index += 2)
			{
				Console.Write(values[index]);
			}
			Console.WriteLine();
			
			for (int index = 0; index < values.Length; index++)
			{
				if (values[index] == 4) break;
				
				Console.Write(values[index]);
			}
			Console.WriteLine();
			
			for (int index = 0; index < values.Length; index++)
			{
				if (values[index] == 4) continue;
				
				Console.Write(values[index]);
			}
			Console.WriteLine();
			
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