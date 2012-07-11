using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sales.Commands
{
	public class SubmitOrder
	{
		public Guid OrderId { get; set; }
		public Guid CustomerId { get; set; }
	}
}
