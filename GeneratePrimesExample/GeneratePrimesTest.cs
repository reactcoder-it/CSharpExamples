/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 20.08.2013
 * Time: 14:52
 */
using System;
using System.Diagnostics;
using NUnit.Framework;

namespace GeneratePrimesExample
{
	/// <summary>
	/// Description of GeneratePrimesTest.
	/// </summary>
	[TestFixture]
	public class GeneratePrimesTest
	{
		[Test]
		public void TestPrimes()
		{
			int[] nullArray = GeneratePrimes.GeneratePrimeNumbers(0);
			Assert.AreEqual(nullArray.Length, 0);
			
			int[] minArray = GeneratePrimes.GeneratePrimeNumbers(2);
			Assert.AreEqual(minArray.Length, 1);
			Assert.AreEqual(minArray[0], 2);
			
			int[] threeArray = GeneratePrimes.GeneratePrimeNumbers(3);
			Assert.AreEqual(threeArray.Length, 2);
			Assert.AreEqual(threeArray[0], 2);
			Assert.AreEqual(threeArray[1], 3);
			
			int[] centArray = GeneratePrimes.GeneratePrimeNumbers(100);
			Assert.AreEqual(centArray.Length, 25);
			Assert.AreEqual(centArray[24], 97);
		}
		
		[Test]
		public void TestExhaustive()
		{
			for (int i=2; i<500; i++)
			{
				VerifyPrimeList(GeneratePrimes.GeneratePrimeNumbers(i));
			}
		}
		
		void VerifyPrimeList(int[] list)
		{
			for (int i=0; i<list.Length; i++)
				VerifyPrime(list[i]);
		}
		
		void VerifyPrime(int n)
		{
			for (int factor=2; factor<n; factor++)
				Assert.IsTrue(n % factor != 0);
		}
	}
}
