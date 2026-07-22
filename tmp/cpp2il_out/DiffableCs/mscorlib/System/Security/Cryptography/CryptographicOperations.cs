namespace System.Security.Cryptography;

public static class CryptographicOperations
{

	[CalledBy(Type = typeof(UnicodeEncoding), Member = "get_Preamble", ReturnType = typeof(System.ReadOnlySpan`1<System.Byte>))]
	[CalledBy(Type = "System.Security.Cryptography.CryptoStream+<ReadAsyncCore>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	public static void ZeroMemory(Span<Byte> buffer) { }

}

