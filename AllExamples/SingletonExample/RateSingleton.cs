/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 01.08.2013
 * Time: 11:21
 */
using System;
using System.Configuration;

namespace SingletonExample
{
	/// <summary>
	/// Description of RateSingleton.
	/// </summary>
	public class RateSingleton
	{
		private volatile static RateSingleton uniqueInstance;
		private static object syncRoot = new object();
		
		private double currentRate = Convert.ToDouble(ConfigurationSettings.AppSettings["CurrentInterestRate"]);
		
		public double CurrentRate
		{
			get
			{
				return currentRate;
			}
			set
			{
				currentRate = value;
			}
		}
		
		private RateSingleton()
		{
		}
		
		public static RateSingleton GetInstance()
		{
			if (uniqueInstance == null)
			{
				lock (syncRoot)
				{
					if (uniqueInstance == null)
					{
						uniqueInstance = new RateSingleton();
					}
				}
			}
			return uniqueInstance;
		}
	}
}
