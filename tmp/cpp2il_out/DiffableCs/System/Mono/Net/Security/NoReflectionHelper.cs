namespace Mono.Net.Security;

internal static class NoReflectionHelper
{

	[CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "GetProvider", ReturnType = typeof(MonoTlsProvider))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProviderInternal", ReturnType = typeof(MobileTlsProvider))]
	internal static object GetProvider() { }

}

