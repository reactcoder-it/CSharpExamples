/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 11:24
 */
using System;

namespace SingletonExample
{
	/// <summary>
	/// Description of RateImplementation.
	/// </summary>
	public class RateImplementation
	{
		public RateImplementation()
		{
		}
		
		public double GetRate()
		{
			RateSingleton rate = RateSingleton.GetInstance();
			return rate.CurrentRate;
		}
	}
}
