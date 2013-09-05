using System;
using System.Collections.Generic;
using System.Windows;
using System.Data;
using System.Xml;
using System.Configuration;

namespace AppWithManyDocumentsExample
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application {
		private List<Window> _documents = new List<Window>();
		public List<Window> Documents {
			get { return this._documents; }
			set { this._documents = value; }
		}
	}
}