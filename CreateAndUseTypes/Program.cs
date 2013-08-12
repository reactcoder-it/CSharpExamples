/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 12.08.2013
 * Time: 11:31
 */
using System;

namespace CreateAndUseTypes
{
	enum Days : byte { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
	
	[Flags]
	enum FDays
	{
		None = 0x0,
		Sunday = 0x1,
		Monday = 0x2,
		Tuesday = 0x4,
		Wednesday = 0x8,
		Thursday = 0x10,
		Friday = 0x20,
		Saturday = 0x40
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Days day = Days.Sat;
			if ((byte)day == 1)
			{
				Console.WriteLine(day);
			}
			
			FDays readingDays = FDays.Monday | FDays.Saturday;
			Console.WriteLine("{0:X2}", (byte)readingDays);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}