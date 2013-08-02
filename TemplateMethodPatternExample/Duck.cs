/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 02.08.2013
 * Time: 11:42
 */
using System;

namespace TemplateMethodPatternExample
{
	/// <summary>
	/// Description of Duck.
	/// </summary>
	public class Duck : IComparable
	{
		String name;
		int weight;
		
		public Duck(String name, int weight)
		{
			this.name = name;
			this.weight = weight;
		}
		
		public override string ToString()
		{
			return name + " weights " + weight;
		}
		
		public int CompareTo(object obj)
		{
			Duck otherDuck = (Duck)obj;
			if (this.weight < otherDuck.weight) {
				return -1;
			} else if (this.weight == otherDuck.weight) {
				return 0;
			} else {
				return 1;
			}
		}
	}
}
