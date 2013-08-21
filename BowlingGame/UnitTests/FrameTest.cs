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
			f.Add(5);
			Assert.AreEqual(5, f.Score);
		}
		
		[Test]
		public void TestOneThrow()
		{
			Game game = new Game();
			game.Add(5);
			Assert.AreEqual(5, game.Score);
		}
	}
}
