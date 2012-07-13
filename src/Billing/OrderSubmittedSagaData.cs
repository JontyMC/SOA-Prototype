﻿using System;
using NServiceBus.Saga;

namespace Billing {
	public class OrderSubmittedSagaData : ISagaEntity {
		public Guid Id { get; set; }
		public string Originator { get; set; }
		public string OriginalMessageId { get; set; }

		[Unique]
		public Guid OrderId { get; set; }
	}
}