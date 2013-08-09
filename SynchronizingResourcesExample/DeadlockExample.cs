/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 09.08.2013
 * Time: 10:28
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizingResourcesExample
{
	/// <summary>
	/// Description of DeadlockExample.
	/// </summary>
	public class DeadlockExample
	{
		static void Main()
		{
			object lockA = new object();
			object lockB = new object();
			
			var up = Task.Run(() =>
			{
				lock (lockA)
				{
					Thread.Sleep(1000);
					lock (lockB)
					{
						Console.WriteLine("Locked A and B");
					}
				}
			});
			
			lock (lockB)
			{
				lock (lockA)
				{
					Console.WriteLine("Locked B and A");
				}
			}
			
			up.Wait();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
