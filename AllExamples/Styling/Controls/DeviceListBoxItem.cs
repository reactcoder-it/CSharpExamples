/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 12/03/2012
 * Time: 15:44
 */
using System;
using System.Windows;
using System.Windows.Controls;

namespace Styling.Controls
{
	/// <summary>
	/// Description of DeviceListBoxItem.
	/// </summary>
	public class DeviceListBoxItem : ListBoxItem
	{
		public DeviceListBoxItem()
		{
			this.DefaultStyleKey = typeof(DeviceListBoxItem);
		}
		
		public static readonly DependencyProperty NumberProperty = DependencyProperty.Register("Number", typeof(string), typeof(DeviceListBoxItem), new PropertyMetadata(default(string)));
		
		public string Number
		{
			get { return (string)GetValue(NumberProperty); }
			set { SetValue(NumberProperty, value); }
		}
	}
}
