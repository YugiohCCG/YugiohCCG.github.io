namespace System.Net;

internal class SystemNetworkCredential : NetworkCredential
{
	internal static readonly SystemNetworkCredential defaultCredential; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static SystemNetworkCredential() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private SystemNetworkCredential() { }

}

