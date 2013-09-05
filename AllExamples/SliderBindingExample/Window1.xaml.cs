/*
 * Created by SharpDevelop.
 * User: user
 * Date: 18.12.2012
 * Time: 7:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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

namespace SliderBindingExample
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
		
		void BtnSetToLarge_Click(object sender, RoutedEventArgs e)
		{
//			this.sliderFontSize.Value = 30;
			this.lblSampleText.FontSize = 30;
		}
	}
}