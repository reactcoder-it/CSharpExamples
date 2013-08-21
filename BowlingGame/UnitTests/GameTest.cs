﻿/*
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
	public class GameTest
	{
		Game game;
		
		[SetUp]
		public void SetUp() { game = new Game(); }

		[Test]
		public void TestOneThrow()
		{
			game.Add(5);
			Assert.AreEqual(5, game.Score);
		}
		
		[Test]
		public void TestTwoThrowsNoMark()
		{
			game.Add(5);
			game.Add(4);
			Assert.AreEqual(9, game.Score);
		}
		
		[Test]
		public void TestFourThrowsNoMark()
		{
			game.Add(5);
			game.Add(4);
			game.Add(7);
			game.Add(2);
			Assert.AreEqual(18, game.Score);
			Assert.AreEqual(9, game.ScoreForFrame(1));
			Assert.AreEqual(18, game.ScoreForFrame(2));
		}
		
		[Test]
		public void TestSimpleSpare()
		{
			game.Add(3);
			game.Add(7);
			game.Add(3);
			Assert.AreEqual(13, game.ScoreForFrame(1));
		}
	}
}
