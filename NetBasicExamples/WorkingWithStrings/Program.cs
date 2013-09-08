/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 05.09.2013
 * Time: 19:37
 */
using System;
using System.Globalization;
using System.Text;

namespace WorkingWithStrings
{
	class Program
	{
		static void DateTimeExample()
		{
			Console.WriteLine("--- DateTime Examples ---");
			
			DateTime d = new DateTime(5767, 1, 1, new HebrewCalendar());
			Console.WriteLine(d);
		}

		static void TimeSpanExample()
		{
			Console.WriteLine("--- TimeSpan Examples ---");
			
			TimeSpan nearlyTenDays = TimeSpan.FromDays(10) - TimeSpan.FromSeconds(1);
			Console.WriteLine(nearlyTenDays.Days);
			Console.WriteLine(nearlyTenDays.Hours);
			Console.WriteLine(nearlyTenDays.Minutes);
			Console.WriteLine(nearlyTenDays.Seconds);
			Console.WriteLine(nearlyTenDays.Milliseconds);
			
			Console.WriteLine(nearlyTenDays.TotalDays);
			Console.WriteLine(nearlyTenDays.TotalHours);
			Console.WriteLine(nearlyTenDays.TotalMinutes);
			Console.WriteLine(nearlyTenDays.TotalSeconds);
			Console.WriteLine(nearlyTenDays.TotalMilliseconds);
		}

		static void GetEncodings()
		{
			Console.WriteLine("--- Get Encodings ---");
			foreach (EncodingInfo info in Encoding.GetEncodings())
				Console.WriteLine(info.Name);
		}

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
			GetEncodings();
			TimeSpanExample();
			DateTimeExample();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}