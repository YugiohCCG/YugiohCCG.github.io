namespace Internal.Cryptography;

[Extension]
internal static class Helpers
{

	[CalledBy(Type = typeof(X509Certificate), Member = "GetCertHash", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetRawCertData", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetKeyAlgorithmParameters", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetPublicKey", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetSerialNumber", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_RawData", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Helper2", Member = "GetMonoCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = "Mono.Security.X509.X509Certificate")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Byte[] CloneByteArray(Byte[] src) { }

	[CallerCount(Count = 0)]
	private static char NibbleToHex(byte b) { }

	[CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Char[] ToHexArrayUpper(Byte[] bytes) { }

	[CalledBy(Type = typeof(X509Certificate), Member = "GetCertHashString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetSerialNumberString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_Thumbprint", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static string ToHexStringUpper(Byte[] bytes) { }

}

