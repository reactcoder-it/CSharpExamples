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
		public void TestTwoThrowsNoMark()
		{
			game.Add(5);
			game.Add(4);
			Assert.AreEqual(9, game.Score);
			Assert.AreEqual(2, game.CurrentFrame);
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
			Assert.AreEqual(3, game.CurrentFrame);
		}
		
		[Test]
		public void TestSimpleSpare()
		{
			game.Add(3);
			game.Add(7);
			game.Add(3);
			Assert.AreEqual(13, game.ScoreForFrame(1));
			Assert.AreEqual(2, game.CurrentFrame);
		}
		
		[Test]
		public void TestSimpleFrameAfterSpare()
		{
			game.Add(3);
			game.Add(7);
			game.Add(3);
			game.Add(2);
			Assert.AreEqual(13, game.ScoreForFrame(1));
			Assert.AreEqual(18, game.ScoreForFrame(2));
			Assert.AreEqual(18, game.Score);
			Assert.AreEqual(3, game.CurrentFrame);
		}
		
		[Test]
		public void TestSimpleStrike()
		{
			game.Add(10);
			game.Add(3);
			game.Add(6);
			Assert.AreEqual(19, game.ScoreForFrame(1));
			Assert.AreEqual(28, game.Score);
			Assert.AreEqual(3, game.CurrentFrame);
		}
		
		[Test]
		public void TestPerfectGame()
		{
			for (int i=0; i<12; i++)
			{
				game.Add(10);
			}
			
			Assert.AreEqual(300, game.Score);
			Assert.AreEqual(10, game.CurrentFrame);
		}
	}
}
