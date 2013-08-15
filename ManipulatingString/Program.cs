/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 15.08.2013
 * Time: 8:09
 */
using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace ManipulatingString
{
	class Program
	{
		static String GetXmlString()
		{
			var stringWriter = new StringWriter();
			using (XmlWriter writer = XmlWriter.Create(stringWriter))
			{
				writer.WriteStartElement("book");
				writer.WriteElementString("price", "19.95");
				writer.WriteEndElement();
				writer.Flush();
			}
			return stringWriter.ToString();
		}
		
		static decimal ReadPrice(string xml)
		{
			var stringReader = new StringReader(xml);
			decimal price = 0;
			using (XmlReader reader = XmlReader.Create(stringReader))
			{
				reader.ReadToFollowing("price");
				price = decimal.Parse(reader.ReadInnerXml(), new CultureInfo("en-US"));
			}
			return price;
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			/* Не выгодный способ с точки зрения использования памяти,
 			 * поскольку переменна создает новый экземпляр строки в памяти
			 * чтоб добавить к нему еще часть строки */
//			String s = String.Empty;
//			for (int i=0; i<10000; i++)
//			{
//				s += "x";
//			}
//			Console.WriteLine(s);
			
			/* Здесь же все происходит во внутреннем буфере,
			 * в который просто добавляется часть строки */
			StringBuilder sb = new StringBuilder(String.Empty);
			
			for (int i=0; i<10000; i++)
			{
				sb.Append("x");
			}
			
			Console.WriteLine(sb.ToString());
			
			Console.WriteLine("\n" + GetXmlString());
			Console.WriteLine("\n" + ReadPrice(GetXmlString()));
			
			string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
			string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels",
				"Abraham Adams", "Ms. Nicole Norris" };
			
			foreach (string name in names)
				Console.WriteLine(Regex.Replace(name, pattern, String.Empty));
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}