using System;

namespace Billing.Events {
	public interface PaymentRecieved {
		Guid OrderId { get; set; }
	}
}