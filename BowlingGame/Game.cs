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
		
		int ball;
		int firstThrow;
		int secondThrow;
		
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
			
			if (currentFrame > 11) currentFrame = 11;
		}
		
		public int ScoreForFrame(int theFrame)
		{
			ball = 0;
			int score = 0;
			for (int currentFrame=0; currentFrame<theFrame; currentFrame++)
			{
				firstThrow = throws[ball];
				if (Strike())
				{
					ball++;
					score += 10 + NextToBalls;
				}
				else
				{
					score += HandleSecondThrow();
				}
			}
			return score;
		}
		
		int NextToBalls
		{
			get { return throws[ball] + throws[ball+1]; }
		}
		
		bool Strike()
		{
			return throws[ball] == 10;
		}
		
		int HandleSecondThrow()
		{
			int score = 0;
			secondThrow = throws[ball + 1];
			int frameScore = firstThrow + secondThrow;
			
			// Для обработки спэа необходим первый бросок в следующем фрейме.
			if (IsSpare())
			{
				ball += 2;
				score += 10 + NextBall;
			}
			else
			{
				score += TwoBallsInFrame;
				ball += 2;
			}
			
			return score;
		}
		
		int TwoBallsInFrame { get { return throws[ball] + throws[ball+1]; } }
		
		int NextBall
		{
			get { return throws[ball]; }
		}
		
		bool IsSpare()
		{
			return throws[ball] + throws[ball+1] == 10;
		}
	}
}
