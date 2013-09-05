/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 25.10.2012
 * Time: 21:17
 */
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Threading;
using System.Threading;

namespace BackgroundWorkerExamples
{
	/// <summary>
	/// Description of Updater.
	/// </summary>
	public class Updater
	{
		BackgroundWorker m_Worker = new BackgroundWorker();
		
		public Updater()
		{
			m_Worker.WorkerReportsProgress = true;
			m_Worker.WorkerSupportsCancellation = true;
			m_Worker.DoWork += new DoWorkEventHandler(m_Worker_DoWork);
			m_Worker.ProgressChanged += new ProgressChangedEventHandler(m_Worker_ProgressChanged);
			m_Worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_Worker_RunWorkerCompleted);
		}

		void m_Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			OnProgressUpdated(new ProgressUpdatedEventArgs(new TestInfo(0, "Проверка завершена!", "Успешно")));
			
		}

		void m_Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			TestInfo testInfo = (TestInfo)e.UserState;
			ProgressUpdatedEventArgs args = new ProgressUpdatedEventArgs(testInfo);
			OnProgressUpdated(args);
		}

		void m_Worker_DoWork(object sender, DoWorkEventArgs e)
		{
			Thread.Sleep(10000);
			TestInfo test = new TestInfo(1, "Test 1", "ОК");
			m_Worker.ReportProgress(1,  test);
			
			Thread.Sleep(10000);
			test = new TestInfo(2, "Test 2", "OK");
			m_Worker.ReportProgress(2, test);
			
			Thread.Sleep(10000);
			test = new TestInfo(3, "Test 3", "OK");
			m_Worker.ReportProgress(3, test);
			
			Thread.Sleep(10000);
			test = new TestInfo(4, "Test 4", "OK");
			m_Worker.ReportProgress(4, test);
		}
		
		public void Start()
		{
			m_Worker.RunWorkerAsync();
		}
		
		public void Dispose()
		{
			m_Worker.Dispose();
		}
		
		public event ProgressUpdatedEventHandler ProgressUpdated;
		protected virtual void OnProgressUpdated(ProgressUpdatedEventArgs e)
		{
			var handler = ProgressUpdated;
			if (handler != null)
			{
				handler(this, e);
			}
		}
	}
}
