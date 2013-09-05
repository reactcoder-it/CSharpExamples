/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 25.10.2012
 * Time: 22:10
 */
using System;

namespace BackgroundWorkerExamples
{
	public delegate void ProgressUpdatedEventHandler(object sender, ProgressUpdatedEventArgs e);
	
	/// <summary>
	/// Description of ProgressUpdatedEventArgs.
	/// </summary>
	public class ProgressUpdatedEventArgs : EventArgs
	{
		public TestInfo Info;
		
		public ProgressUpdatedEventArgs(TestInfo info)
		{
			this.Info = info;
		}
	}
}
