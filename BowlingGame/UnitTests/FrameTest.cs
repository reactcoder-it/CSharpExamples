/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 21.08.2013
 * Time: 11:47
 */
using System;
using NUnit.Framework;

namespace BowlingGame.UnitTests
{
	/// <summary>
	/// Description of FrameTest.
	/// </summary>
	[TestFixture]
	public class FrameTest
	{
		[Test]
		public void TestScoreNoThrows()
		{
			Frame f = new Frame();
			Assert.AreEqual(0, f.Score);
		}
	}
}
