using Billing.Events;
using ITOps.PaymentProviderIntegration;
using NServiceBus;
using NServiceBus.Saga;
using Sales.Events;

namespace Billing {
	public class OrderSubmittedSaga : Saga<OrderSubmittedSagaData>,
		IAmStartedByMessages<OrderSubmitted>,
		IHandleMessages<DataCashResponse> {
		public void Handle(OrderSubmitted message) {
			Data.OrderId = message.OrderId;

			// Send message to integration endpoint to process payment
		}

		public void Handle(DataCashResponse message) {
			Bus.Publish<PaymentRecieved>(x => x.OrderId = message.OrderId);
		}
	}
}