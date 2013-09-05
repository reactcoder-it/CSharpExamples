/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 25.10.2012
 * Time: 21:14
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

namespace BackgroundWorkerExamples
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		
		void BtnTest_Click(object sender, RoutedEventArgs e)
		{
			Updater test = new Updater();
			test.ProgressUpdated += new ProgressUpdatedEventHandler(test_ProgressUpdated);
			test.Start();
			this.btnTest.IsEnabled = false;
		}

		void test_ProgressUpdated(object sender, ProgressUpdatedEventArgs e)
		{
			this.tbxDebug.AppendText(DateTime.Now.ToString() + " " + e.Info.ToString() + "\r\n");
			if (e.Info.Name == "Проверка завершена!")
				this.btnTest.IsEnabled = true;
		}
	}
}