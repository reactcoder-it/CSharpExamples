/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 13.12.2012
 * Time: 21:08
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

namespace MouseInputExample
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
		
		void Canvas_MouseMove(object sender, MouseEventArgs e)
		{
			Point pt = e.GetPosition(this);
			this.txtInfo.Text = String.Format("You are at ({0},{1}) in window coordinates", pt.X, pt.Y);
		}
	}
}