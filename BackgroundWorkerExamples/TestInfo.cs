/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 25.10.2012
 * Time: 21:31
 */
using System;

namespace BackgroundWorkerExamples
{
	/// <summary>
	/// Description of TestInfo.
	/// </summary>
	public class TestInfo
	{
		public int Number;
		public string Name;
		public string Result;
		
		public TestInfo(int number, string name, string result)
		{
			this.Number = number;
			this.Name = name;
			this.Result = result;
		}
		
		public override string ToString()
		{
			return string.Format("[TestInfo Number={0}, Name={1}, Result={2}]", Number, Name, Result);
		}

	}
}
