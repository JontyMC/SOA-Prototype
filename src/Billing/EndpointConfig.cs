using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace Billing
{
	class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, IWantCustomInitialization
	{
		public void Init()
		{
			Configure.With()
				.NinjectBuilder()
				.RavenPersistence()
				//this overrides the NServiceBus default convention of IEvent
				.DefiningEventsAs(t => t.Namespace != null && t.Namespace.EndsWith("Events"));
		}
	}
}