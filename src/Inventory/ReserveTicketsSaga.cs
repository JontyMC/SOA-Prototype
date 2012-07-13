using System;
using Billing.Events;
using Inventory.Commands;
using Inventory.Events;
using NServiceBus;
using NServiceBus.Saga;

namespace Inventory
{
	public class ReserveTicketsSaga : Saga<ReserveTicketsSagaData>,
		IAmStartedByMessages<ReserveTickets>,
		IHandleTimeouts<ReservedTicketsTimeout>,
		IHandleMessages<PaymentRecieved>
	{
		public void Handle(ReserveTickets message) {
			Data.OrderId = message.OrderId;

			RequestUtcTimeout<ReservedTicketsTimeout>(TimeSpan.FromSeconds(10));

			// Reserve tickets in db
			Console.WriteLine("Tickets reserved for order " + message.OrderId);

			Bus.Publish<TicketsReserved>(x => x.OrderId = message.OrderId);
		}

		public void Timeout(ReservedTicketsTimeout state) {
			// Release tickets in DB

			Bus.Publish<TicketsReservationExpired>(x => x.OrderId = Data.OrderId);
		}

		public void Handle(PaymentRecieved message) {
			MarkAsComplete();
		}
	}
}