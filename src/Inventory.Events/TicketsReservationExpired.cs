using System;

namespace Inventory.Events {
	public interface TicketsReservationExpired {
		Guid OrderId { get; set; }
	}
}