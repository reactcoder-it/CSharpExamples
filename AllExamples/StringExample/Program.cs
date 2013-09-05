/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 31.07.2013
 * Time: 21:52
 */
using System;

namespace StringExample
{
	class Program
	{
		public static int Main()
		{
			Console.WriteLine("Hello World!");
			
			String s1 = "Строка";
			String s2 = s1;
			Console.WriteLine("s1 равно " + s1);
			Console.WriteLine("s2 равно " + s2);
			
			s1 = "Другая строка";
			Console.WriteLine("s1 теперь равно " + s1);
			Console.WriteLine("s2 теперь равно " + s2);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			return 0;
		}
	}
}