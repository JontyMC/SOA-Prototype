using System;

namespace Billing.Events {
	public class OrderBilled {
		public Guid OrderId { get; set; } 
	}
}