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
		private static bool[] crossedOut;
		private static int[] result;
		
		public static int[] GeneratePrimeNumbers(int maxValue)
		{
			if (maxValue < 2)
				return new int[0];
			else
			{
				UncrossIntegersUpTo(maxValue);
				CrossOutMultiples();
				PutUncrossedIntegersIntoResult();
				return result;
			}
		}
		
		static void PutUncrossedIntegersIntoResult()
		{
			result = new int[NumberOfUncrossedIntegers()];
			for (int j=0, i=2; i<crossedOut.Length; i++)
			{
				if (NotCrossed(i))
					result[j++] = i;
			}
		}
		
		static int NumberOfUncrossedIntegers()
		{
			int count = 0;
			for (int i=2; i<crossedOut.Length; i++)
			{
				if (NotCrossed(i))
					count++;
			}
			return count;
		}
		
		static void CrossOutMultiples()
		{
			int limit = DetermineIterationLimit();
			for (int i=2; i<limit; i++)
			{
				if (NotCrossed(i))
					CrossOutMultiplesOf(i);
			}
		}
		
		static int DetermineIterationLimit()
		{
			double iterationLimit = Math.Sqrt(crossedOut.Length);
			return (int)iterationLimit;
		}
		
		static void CrossOutMultiplesOf(int i)
		{
			for (int multiple = 2*i; multiple < crossedOut.Length; multiple += i)
				crossedOut[multiple] = true;
		}
		
		static bool NotCrossed(int i)
		{
			return crossedOut[i] == false;
		}

		static void UncrossIntegersUpTo(int maxValue)
		{
			crossedOut = new bool[maxValue + 1];
			for (int i=2; i<crossedOut.Length; i++)
				crossedOut[i] = false;
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