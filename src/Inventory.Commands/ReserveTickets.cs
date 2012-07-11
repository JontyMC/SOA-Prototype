using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Commands
{
	public class ReserveTickets
	{
		public Guid OrderId { get; set; }
		public Guid TicketId { get; set; }
		public int Quantity { get; set; }
	}
}
