using System;
using Billing.Commands;
using CustomerCare.Commands;
using Inventory.Commands;
using NServiceBus;
using Sales.Commands;
using Shipping.Commands;

namespace TestClient {
	public class ServerEndpoint : IWantToRunAtStartup {
		public IBus Bus { get; set; }

		public void Run() {
			var ticketId = Guid.NewGuid();
			var orderId = Guid.NewGuid();
			var customerId = Guid.NewGuid();

			ReserveTickets(orderId, ticketId);
			StoreCustomerDetails(customerId);
			StoreBillingAddress(orderId);
			StoreShippingAddress(orderId);
			SubmitOrder(orderId, customerId);
		}

		void ReserveTickets(Guid orderId, Guid ticketId) {
			Console.WriteLine("Press 'Enter' to ReserveTickets");
			Console.ReadLine();

			var command = new ReserveTickets {
				OrderId = orderId,
				TicketId = ticketId,
				Quantity = 2
			};

			Bus.Send(command);
		}

		void StoreCustomerDetails(Guid customerId) {
			Console.WriteLine("Press 'Enter' to StoreCustomerDetails");
			Console.ReadLine();

			var command = new StoreCustomerDetails {
				Id = customerId,
				Name = "Jon Curtis"
			};

			Bus.Send(command);
		}

		void StoreBillingAddress(Guid orderId) {
			Console.WriteLine("Press 'Enter' to StoreBillingAddress");
			Console.ReadLine();

			var command = new StoreBillingAddress {
				OrderId = orderId,
				Address = "Blah"
			};

			Bus.Send(command);
		}

		void StoreShippingAddress(Guid orderId) {
			Console.WriteLine("Press 'Enter' to StoreBillingAddress");
			Console.ReadLine();

			var command = new StoreShippingAddress {
				OrderId = orderId,
				Address = "Blah"
			};

			Bus.Send(command);
		}

		void SubmitOrder(Guid orderId, Guid customerId) {
			Console.WriteLine("Press 'Enter' to SubmitOrder");
			Console.ReadLine();

			var command = new SubmitOrder {
				OrderId = orderId,
				CustomerId = customerId
			};

			Bus.Send(command);
		}

		public void Stop() {

		}
	}
}