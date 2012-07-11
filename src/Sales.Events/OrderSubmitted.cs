using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sales.Events
{
	public class OrderSubmitted
	{
		public Guid OrderId { get; set; }
		public Guid CustomerId { get; set; }
	}
}
