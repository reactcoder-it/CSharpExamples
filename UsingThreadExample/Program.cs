/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 07.08.2013
 * Time: 10:49
 */
using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace UsingThreadExample
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			string result = DownloadContent().Result;
			Console.WriteLine(result);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static async Task<String> DownloadContent()
		{
			using (HttpClient client = new HttpClient())
			{
				String result = await client.GetStringAsync("http://www.github.com");
				return result;
			}
		}
	}
}