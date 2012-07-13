using System;

namespace Inventory.Events {
	public interface TicketsReserved {
		Guid OrderId { get; set; }
	}
}