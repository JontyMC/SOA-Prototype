using NServiceBus;

namespace Inventory {
	class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, IWantCustomInitialization {
		public void Init() {
			Configure.With()
				.NinjectBuilder()
				.RavenPersistence()
				//this overrides the NServiceBus default convention of IEvent
				.DefiningEventsAs(t => t.Namespace != null && t.Namespace.EndsWith("Events"))
				.DefiningCommandsAs(t => t.Namespace != null && t.Namespace.EndsWith("Commands"));
		}
	}
}