/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 21.08.2013
 * Time: 11:46
 */
using System;

namespace BowlingGame
{
	/// <summary>
	/// Description of Frame.
	/// </summary>
	public class Frame
	{
		int score;
		
		public int Score
		{
			get { return score; }
		}
		
		public void Add(int pins)
		{
			score += pins;
		}
	}
}
