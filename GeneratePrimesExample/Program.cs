/*
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
		private static bool[] isCrossed;
		private static int[] result;
		
		public static int[] GeneratePrimeNumbers(int maxValue)
		{
			if (maxValue < 2)
				return new int[0];
			else
			{
				InitializeArrayOfIntegers(maxValue);
				CrossOutMultiples();
				PutUncrossedIntegersIntoResult();
				return result;
			}
		}
		
		static void PutUncrossedIntegersIntoResult()
		{
			result = new int[NumberOfUncrossedIntegers()];
			for (int j=0, i=2; i<isCrossed.Length; i++)
			{
				if (NotCrossed(i))
					result[j++] = i;
			}
		}
		
		static int NumberOfUncrossedIntegers()
		{
			int count = 0;
			for (int i=2; i<isCrossed.Length; i++)
			{
				if (NotCrossed(i))
					count++;
			}
			return count;
		}
		
		static void CrossOutMultiples()
		{
			int maxPrimeFactor = CalcMaxPrimeFactor();
			for (int i=2; i<maxPrimeFactor + 1; i++)
			{
				if (NotCrossed(i))
					CrossOutMultiplesOf(i);
			}
		}
		
		static void CrossOutMultiplesOf(int i)
		{
			for (int multiple = 2*i; multiple < isCrossed.Length; multiple += i)
				isCrossed[multiple] = true;
		}
		
		static bool NotCrossed(int i)
		{
			return isCrossed[i] == false;
		}
		
		static int CalcMaxPrimeFactor()
		{
			double maxPrimeFactor = Math.Sqrt(isCrossed.Length) + 1;
			return (int)maxPrimeFactor;
		}
		
		public static void InitializeArrayOfIntegers(int maxValue)
		{
			int i;
			
			isCrossed = new bool[maxValue + 1];
			for (i=2; i<isCrossed.Length; i++)
				isCrossed[i] = false;
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