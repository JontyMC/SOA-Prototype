using System;

namespace Billing.Commands {
	public class StoreBillingAddress {
		public Guid OrderId { get; set; }
		public string Address { get; set; }
	}
}
