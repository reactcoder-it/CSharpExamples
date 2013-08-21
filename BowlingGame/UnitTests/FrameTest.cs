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
		
		[Test]
		public void TestTwoThrowsNoMark()
		{
			Game game = new Game();
			game.Add(5);
			game.Add(4);
			Assert.AreEqual(9, game.Score);
		}
		
		[Test]
		public void TestFourThrowsNoMark()
		{
			Game game = new Game();
			game.Add(5);
			game.Add(4);
			game.Add(7);
			game.Add(2);
			Assert.AreEqual(18, game.Score);
			Assert.AreEqual(9, game.ScoreForFrame(1));
			Assert.AreEqual(18, game.ScoreForFrame(2));
		}
	}
}
