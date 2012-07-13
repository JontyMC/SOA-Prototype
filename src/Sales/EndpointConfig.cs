using NServiceBus;

namespace Sales {
	class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, IWantCustomInitialization {
		public void Init() {
			Configure.With()
				.NinjectBuilder()
				.RavenPersistence()
				.Log4Net()
				//this overrides the NServiceBus default convention of IEvent
				.DefiningEventsAs(t => t.Namespace != null && t.Namespace.EndsWith("Events"))
				.DefiningCommandsAs(t => t.Namespace != null && t.Namespace.EndsWith("Commands"));
		}
	}
}