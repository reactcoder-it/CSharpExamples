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
		int score;
		int[] throws = new int[21];
		int currentThrow;
		
		public int Score { get { return score; } }
		public int CurrentFrame { get { return 1 + (currentThrow - 1) / 2; } }
		
		public void Add(int pins)
		{
			throws[currentThrow++] = pins;
			score += pins;
		}
		
		public int ScoreForFrame(int theFrame)
		{
			int ball = 0;
			int score = 0;
			for (int currentFrame=0; currentFrame<theFrame; currentFrame++)
			{
				int firstThrow = throws[ball++];
				int secondThrow = throws[ball++];
				
				int frameScore = firstThrow + secondThrow;
				
				// Для обработки спэа необходим первый бросок в следующем фрейме.
				if (frameScore == 10)
					score += frameScore + throws[ball];
				else
					score += frameScore;
			}
			return score;
		}
	}
}
