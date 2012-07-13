using System;

namespace Shipping.Commands {
	public class StoreShippingAddress {
		public Guid OrderId { get; set; }
		public string Address { get; set; }
	}
}