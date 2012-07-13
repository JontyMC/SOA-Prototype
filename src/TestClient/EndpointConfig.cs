using NServiceBus;

namespace TestClient {
	class EndpointConfig : IConfigureThisEndpoint, AsA_Client, IWantCustomInitialization {
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