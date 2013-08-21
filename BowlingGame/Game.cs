/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 21.08.2013
 * Time: 11:59
 */
using System;

namespace BowlingGame
{
	/// <summary>
	/// Description of Game.
	/// </summary>
	public class Game
	{
		bool isFirstThrow = true;
		int currentFrame = 0;
		Scorer scorer = new Scorer();
		
		public int Score { get { return ScoreForFrame(currentFrame); } }
		
		public void Add(int pins)
		{
			scorer.AddThrow(pins);
			AdjustCurrentFrame(pins);
		}
		
		public int ScoreForFrame(int theFrame) { return scorer.ScoreForFrame(theFrame); }
		
		void AdjustCurrentFrame(int pins)
		{
			if (LastBallInFrame(pins))
				AdvanceFrame();
			else
				isFirstThrow = false;
		}
		
		bool LastBallInFrame(int pins) { return Strike(pins) || (!isFirstThrow); }
		bool Strike(int pins) { return isFirstThrow && pins == 10; }
		
		bool AdjustFrameForStrike(int pins)
		{
			if (pins == 10)
			{
				AdvanceFrame();
				return true;
			}
			return false;
		}
		
		void AdvanceFrame()
		{
			currentFrame++;
			if (currentFrame > 10) currentFrame = 10;
		}
	}
}
