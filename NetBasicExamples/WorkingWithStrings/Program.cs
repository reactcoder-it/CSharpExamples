/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 05.09.2013
 * Time: 19:37
 */
using System;

namespace WorkingWithStrings
{
	class Program
	{
		static void WorkingWithChar()
		{
			Console.WriteLine("--- Working with char ---");
			Console.WriteLine(Char.ToUpper('c'));
			Console.WriteLine(Char.IsWhiteSpace('\t'));
			Console.WriteLine(Char.GetUnicodeCategory('\t'));
		}
		
		static void WorkingWithString()
		{
			Console.WriteLine("--- Working with string ---");
			string s1 = "Hello";
			string s2 = "First Line\r\nSecond Line";
			string s3 = @"\\server\fileshare\helloworld.cs";
			Console.WriteLine(s1);
			Console.WriteLine(s2);
			Console.WriteLine(s3);
			
			char[] ca = "Hello".ToCharArray();
			string s = new string(ca);
			Console.WriteLine(s);
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			WorkingWithChar();
			WorkingWithString();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}