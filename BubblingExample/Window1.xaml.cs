/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 12.12.2012
 * Time: 20:12
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace BubblingExample
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
		
		protected int eventCounter = 0;
		
		private void Something_MouseUp(object sender, RoutedEventArgs e)
		{
			eventCounter++;
			string message = "#" + eventCounter.ToString() + ":\r\n" +
				" Sender: " + sender.ToString() + "\r\n" +
				" Source: " + e.Source + "\r\n" +
				" Original Source: " + e.OriginalSource;
			lstMessages.Items.Add(message);
			e.Handled = (bool)chkHandle.IsChecked;
		}
		
		void CmdClear_Click(object sender, RoutedEventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}