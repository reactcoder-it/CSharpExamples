/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 04.11.2012
 * Time: 18:20
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

namespace DinamicCreatingControls
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
			
			CreateButtonArray(this.wrpPanel1);
		}
		
		/// <summary>
		/// Dynamic creating components in WrapPanel.
		/// </summary>
		/// <param name="pnl"></param>
		public void CreateButtonArray(WrapPanel pnl)
		{
			Button btn = null;
			
			for (int i=0; i<10; i++)
			{
				btn = new Button();
				btn.Content = "button" + i.ToString();
				btn.Width = 100;
				btn.Height = 23;
				btn.Margin = new Thickness(5,5,5,5);
				btn.Click += new RoutedEventHandler(btn_Click);
				pnl.Children.Add(btn);
			}
		}

		void btn_Click(object sender, RoutedEventArgs e)
		{
			Button btn = sender as Button;
			MessageBox.Show("Нажата кнопка " + btn.Content.ToString(), this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
		}
	}
}