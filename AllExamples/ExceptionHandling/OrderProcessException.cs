/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 12.08.2013
 * Time: 8:48
 */
using System;
using System.Runtime.Serialization;

namespace ExceptionHandling
{
	/// <summary>
	/// Description of OrderProcessException.
	/// </summary>
	[Serializable]
	public class OrderProcessException : Exception, ISerializable
	{
		public int OrderId { get; set; }
		
		public OrderProcessException(int orderId)
		{
			this.OrderId = orderId;
			this.HelpLink = "http://www.mydomain.com/infoaboutexception";
		}
		
		public OrderProcessException(int orderId, string message)
			: base(message)
		{
			this.OrderId = orderId;
			this.HelpLink = "http://www.mydomain.com/infoaboutexception";
		}
		
		public OrderProcessException(int orderId, string message, Exception innerException)
			: base(message, innerException)
		{
			this.OrderId = orderId;
			this.HelpLink = "http://www.mydomain.com/infoaboutexception";
		}
		
		protected OrderProcessException(SerializationInfo info,StreamingContext context)
		{
			this.OrderId = (int)info.GetValue("OrderId", typeof(int));
		}
		
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("OrderId", OrderId, typeof(int));
		}
	}
}
