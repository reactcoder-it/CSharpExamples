/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 14.08.2013
 * Time: 22:35
 */
using System;
using System.IO;

namespace ImplementingIDisposableAndFinalizer
{
	class UnmanagedWrapper : IDisposable
	{
		public FileStream Stream { get; private set; }
		
		public UnmanagedWrapper() {
			this.Stream = File.Open("temp.dat", FileMode.Create);
		}
		
		~UnmanagedWrapper() {
			Dispose(false);
		}
		
		public void Close() {
			Dispose();
		}
		
		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		public void Dispose(bool disposing) {
			if (disposing) {
				if (Stream != null) {
					Stream.Close();
				}
			}
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}