﻿/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 20.08.2013
 * Time: 14:41
 */
using System;
using System.Diagnostics;

namespace GeneratePrimesExample
{
	public class GeneratePrimes
	{
		public static int[] GeneratePrimeNumbers(int maxValue)
		{
			if (maxValue >= 2)
			{
				int s = maxValue + 1;
				bool[] f = new bool[s];
				int i;
				
				for (i=0; i<s; i++)
					f[i] = true;
				
				f[0] = f[1] = false;
				
				int j;
				for (i=2; i<Math.Sqrt(s) + 1; i++)
				{
					if (f[i])
					{
						for (j=2*i; j<s; j+=i)
							f[j] = false;
					}
				}
				
				int count = 0;
				for (i=0; i<s; i++)
				{
					if (f[i])
						count++;
				}
				
				int[] primes = new int[count];
				for(i=0, j=0; i<s;i++)
				{
					if (f[i])
						primes[j++] = i;
				}
				return primes;
			}
			else
				return new int[0];
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			int[] nullArray = GeneratePrimes.GeneratePrimeNumbers(0);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}