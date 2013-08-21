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
		bool isFirstThrow = true;
		int currentFrame = 1;
		
		public int Score { get { return ScoreForFrame(CurrentFrame - 1); } }
		public int CurrentFrame { get { return currentFrame; } }
		
		public void Add(int pins)
		{
			throws[currentThrow++] = pins;
			score += pins;
			
			AdjustCurrentFrame(pins);
		}
		
		void AdjustCurrentFrame(int pins)
		{
			if (isFirstThrow)
			{
				if (pins == 10)
					currentFrame++;
				else
					isFirstThrow = false;
			}
			else
			{
				isFirstThrow = true;
				currentFrame++;
			}
			
			if (currentFrame > 10) currentFrame = 10;
		}
		
		public int ScoreForFrame(int theFrame)
		{
			int ball = 0;
			int score = 0;
			for (int currentFrame=0; currentFrame<theFrame; currentFrame++)
			{
				int firstThrow = throws[ball++];
				if (firstThrow == 10)
				{
					score += 10 + throws[ball] + throws[ball+1];
				}
				else
				{
					int secondThrow = throws[ball++];
					int frameScore = firstThrow + secondThrow;
					
					// Для обработки спэа необходим первый бросок в следующем фрейме.
					if (frameScore == 10)
						score += frameScore + throws[ball];
					else
						score += frameScore;
				}
			}
			return score;
		}
	}
}
