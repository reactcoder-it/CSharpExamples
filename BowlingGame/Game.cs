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
		int currentFrame = 1;
		Scorer scorer = new Scorer();
		
		public int Score { get { return ScoreForFrame(CurrentFrame - 1); } }
		public int CurrentFrame { get { return currentFrame; } }
		
		public void Add(int pins)
		{
			scorer.AddThrow(pins);
			AdjustCurrentFrame(pins);
		}
		
		public int ScoreForFrame(int theFrame)
		{
			return scorer.ScoreForFrame(theFrame);
		}
		
		void AdjustCurrentFrame(int pins)
		{
			if (isFirstThrow)
			{
				if (pins == 10)
					AdvanceFrame();
				else
					isFirstThrow = false;
			}
			else
			{
				isFirstThrow = true;
				AdvanceFrame();
			}
		}
		
		void AdvanceFrame()
		{
			currentFrame++;
			if (currentFrame > 11) currentFrame = 11;
		}
	}
}
