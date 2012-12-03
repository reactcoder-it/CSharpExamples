/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 12/03/2012
 * Time: 16:41
 */
using System;
using System.Windows;
using System.Windows.Controls;

namespace Styling.Controls
{
	/// <summary>
	/// Description of Tile.
	/// </summary>
	public class Tile : Button
	{
		public Tile()
		{
			this.DefaultStyleKey = typeof(Tile);
		}
		
		public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Tile), new PropertyMetadata(default(string)));
		
		public string Title
		{
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}
		
		public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(string), typeof(Tile), new PropertyMetadata(default(string)));
		
		public string Value
		{
			get { return (string)GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}
	}
}
