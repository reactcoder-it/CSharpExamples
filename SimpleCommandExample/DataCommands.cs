/*
 * Created by SharpDevelop.
 * User: user
 * Date: 18.12.2012
 * Time: 14:59
 */
using System;
using System.Windows.Input;

namespace SimpleCommandExample
{
	/// <summary>
	/// Description of DataCommands.
	/// </summary>
	public class DataCommands
	{
		private static RoutedUICommand requery;
		static DataCommands()
		{
			InputGestureCollection inputs = new InputGestureCollection();
			inputs.Add(new KeyGesture(Key.R, ModifierKeys.Control, "Ctrl+R"));
			requery = new RoutedUICommand("Requery", "Requery", typeof(DataCommands), inputs);
		}
		public static RoutedUICommand Requery
		{
			get { return requery; }
		}
	}
}
