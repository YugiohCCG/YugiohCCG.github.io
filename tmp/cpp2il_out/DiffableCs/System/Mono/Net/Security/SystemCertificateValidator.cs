namespace Mono.Net.Security;

internal static class SystemCertificateValidator
{
	private static bool is_macosx; //Field offset: 0x0
	private static X509KeyUsageFlags s_flags; //Field offset: 0x4

	[CallerCount(Count = 0)]
	private static SystemCertificateValidator() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal static bool NeedsChain(MonoTlsSettings settings) { }

}

