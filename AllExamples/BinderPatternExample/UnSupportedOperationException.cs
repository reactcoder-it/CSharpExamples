/*
 * Created by SharpDevelop.
 * User: VMP
 * Date: 04.08.2013
 * Time: 21:49
 */
using System;

namespace BinderPatternExample
{
	/// <summary>
	/// Description of UnSupportedOperationException.
	/// </summary>
	public class UnSupportedOperationException : ApplicationException
	{
		private String message;
		
		public override string Message {
			get { return message; }
		}
		
		public UnSupportedOperationException() {
		}
		
		public UnSupportedOperationException(String message)
			: base(message) {
			this.message = message;
		}
	}
}
