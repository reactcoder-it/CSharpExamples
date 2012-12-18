/*
 * Created by SharpDevelop.
 * User: user
 * Date: 18.12.2012
 * Time: 10:13
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

namespace CommandsExample
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
		
		private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("New command triggered by " + e.Source.ToString());
		}
	}
}