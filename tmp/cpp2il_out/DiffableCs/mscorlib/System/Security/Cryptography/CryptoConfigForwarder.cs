namespace System.Security.Cryptography;

internal static class CryptoConfigForwarder
{

	[CalledBy(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	internal static object CreateFromName(string name) { }

}

