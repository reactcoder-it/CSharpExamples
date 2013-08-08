/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 08.08.2013
 * Time: 12:35
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Threading.Tasks;

namespace CofigureAwaitUsing
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		
		private async void Button_Click(object sender, RoutedEventArgs e)
		{
			HttpClient httpClient = new HttpClient();
			
			string content = await httpClient
				.GetStringAsync("http://www.microsoft.com")
				.ConfigureAwait(false);
			
			using (FileStream sourceStream = new FileStream("temp.html", FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true))
			{
				byte[] encodedText = Encoding.Unicode.GetBytes(content);
				await sourceStream.WriteAsync(encodedText, 0, encodedText.Length).ConfigureAwait(false);
			};
		}
	}
}