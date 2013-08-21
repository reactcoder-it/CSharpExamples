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
		
		public int Score { get { return ScoreForFrame(CurrentFrame - 1); } }
		
		int currentFrame = 1;
		public int CurrentFrame { get { return currentFrame; } }
		
		public void Add(int pins)
		{
			throws[currentThrow++] = pins;
			score += pins;
			
			AdjustCurrentFrame();
		}
		
		void AdjustCurrentFrame()
		{
			if (isFirstThrow)
			{
				isFirstThrow = false;
				currentFrame++;
			}
			else
				isFirstThrow = true;
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
