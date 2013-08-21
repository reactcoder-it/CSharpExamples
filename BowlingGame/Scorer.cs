/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 21.08.2013
 * Time: 14:54
 */
using System;

namespace BowlingGame
{
	/// <summary>
	/// Description of Scorer.
	/// </summary>
	public class Scorer
	{
		int ball;
		int[] throws = new int[21];
		int currentThrow;
		
		public Scorer() { }
		
		public void AddThrow(int pins) { throws[currentThrow++] = pins; }
		
		public int ScoreForFrame(int theFrame)
		{
			ball = 0;
			int score = 0;
			for (int currentFrame=0; currentFrame<theFrame; currentFrame++)
			{
				if (Strike())
				{
					score += 10 + NextTwoBallsForStrike;
					ball++;
				}
				else if (Spare())
				{
					score += 10 + NextBallForSpare;
					ball += 2;
				}
				else
				{
					score += TwoBallsInFrame;
					ball += 2;
				}
			}
			return score;
		}
		
		bool Strike() { return throws[ball] == 10; }
		bool Spare() { return throws[ball] + throws[ball+1] == 10; }
		
		int NextTwoBallsForStrike { get { return throws[ball + 1] + throws[ball + 2]; } }
		int NextBallForSpare { get { return throws[ball + 2]; } }
		int TwoBallsInFrame { get { return throws[ball] + throws[ball+1]; } }
	}
}
