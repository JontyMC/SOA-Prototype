using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus.Saga;

namespace Inventory
{
	public class ReserveTicketsSaga : Saga<ReserveTicketsSagaData>
	{
	}

	public class ReserveTicketsSagaData : IContainSagaData
	{

	}
}
