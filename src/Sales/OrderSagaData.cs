using System;
using NServiceBus.Saga;

namespace Sales {
	public class OrderSagaData : ISagaEntity {
		public Guid Id { get; set; }
		public string Originator { get; set; }
		public string OriginalMessageId { get; set; }

		[Unique]
		public Guid OrderId { get; set; }
		public OrderStatus Status { get; set; }
	}
}