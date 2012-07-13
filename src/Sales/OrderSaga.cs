using System;
using Inventory.Events;
using NServiceBus;
using NServiceBus.Saga;
using Sales.Commands;
using Sales.Events;

namespace Sales {
	public class OrderSaga : Saga<OrderSagaData>,
		IAmStartedByMessages<TicketsReserved>,
		IHandleMessages<SubmitOrder> {

		public override void ConfigureHowToFindSaga() {
			ConfigureMapping<SubmitOrder>(x => x.OrderId, x => x.OrderId);
		}

		public void Handle(TicketsReserved message) {
			Data.OrderId = message.OrderId;
			Data.Status = OrderStatus.TicketsReserved;

			Console.WriteLine("Order status set to tickets received for order " + message.OrderId);
		}

		public void Handle(SubmitOrder message) {
			Data.Status = OrderStatus.Submitted;

			Bus.Publish<OrderSubmitted>(x => x.OrderId = message.OrderId);
		}
	}
}