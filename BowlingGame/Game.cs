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
		
		public void Add(int pins)
		{
			throws[currentThrow++] = pins;
			score += pins;
		}
		
		public int ScoreForFrame(int frame)
		{
			int score = 0;
			for (int ball=0; frame>0 && ball<currentThrow; ball+=2, frame--)
			{
				score += throws[ball] + throws[ball + 1];
			}
			return score;
		}
	}
}
