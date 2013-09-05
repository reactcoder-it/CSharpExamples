/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 14.12.2012
 * Time: 20:06
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

namespace AppWithManyDocumentsExample
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
		
		void Button_Click(object sender, RoutedEventArgs e)
		{
			Window win = new Window();
			win.Owner = this;
			win.Width = 300;
			win.Height = 300;
			win.Show();
			((App)Application.Current).Documents.Add(win);
		}
		
		void Button_Click1(object sender, RoutedEventArgs e)
		{
			foreach (Window win in ((App)Application.Current).Documents)
			{
				win.Close();
			}
		}
	}
}