/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 13.12.2012
 * Time: 21:52
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

namespace DragDropExample
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
		
		void LblSource_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Label lbl = (Label)sender;
			DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.Copy);
		}
		
		void LblDestination_Drop(object sender, DragEventArgs e)
		{
			((Label)sender).Content = e.Data.GetData(DataFormats.Text);
		}
		
		void LblDestination_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
				e.Effects = DragDropEffects.Copy;
			else
				e.Effects = DragDropEffects.None;
		}
	}
}