/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 18.12.2012
 * Time: 12:58
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

namespace SimpleCommandExample
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		private bool _isDirty = false;
		
		public Window1()
		{
			InitializeComponent();
		}
		
		private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("New command triggered by " + e.Source.ToString());
		}
		
		private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("New command triggered by " + e.Source.ToString());
		}
		
		void Txt1_TextChanged(object sender, TextChangedEventArgs e)
		{
			this._isDirty = true;
		}
		
		void SaveCommand_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = this._isDirty;
		}
		
		void RequeryCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("New command triggered by " + e.Source.ToString());
		}
	}
}