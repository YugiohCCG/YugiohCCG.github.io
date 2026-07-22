namespace Mono.Security.Protocol.Ntlm;

public static class ChallengeResponse2
{
	private static Byte[] magic; //Field offset: 0x0
	private static Byte[] nullEncMagic; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static ChallengeResponse2() { }

	[CalledBy(Type = typeof(Type3Message), Member = "GetBytes", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Type2Message), Member = "get_Nonce", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2_Session", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(Byte[]&), typeof(Byte[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChallengeResponse2), Member = "Compute_LM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ChallengeResponse2), Member = "Compute_NTLM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out Byte[] lm, out Byte[] ntlm) { }

	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(NtlmAuthLevel), typeof(string), typeof(string), typeof(string), typeof(Byte[]&), typeof(Byte[]&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DES), Member = "Create", ReturnType = typeof(DES))]
	[Calls(Type = typeof(ChallengeResponse2), Member = "PasswordToKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ChallengeResponse2), Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private static Byte[] Compute_LM(string password, Byte[] challenge) { }

	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(NtlmAuthLevel), typeof(string), typeof(string), typeof(string), typeof(Byte[]&), typeof(Byte[]&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ChallengeResponse2), Member = "Compute_NTLM_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ChallengeResponse2), Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	private static Byte[] Compute_NTLM(string password, Byte[] challenge) { }

	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2_Session", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(Byte[]&), typeof(Byte[]&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MD4), Member = "Create", ReturnType = typeof(MD4))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Byte[] Compute_NTLM_Password(string password) { }

	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(NtlmAuthLevel), typeof(string), typeof(string), typeof(string), typeof(Byte[]&), typeof(Byte[]&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type2Message), Member = "get_Nonce", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type2Message), Member = "get_TargetInfo", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(HashAlgorithm), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(HMACMD5), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(ChallengeResponse2), Member = "Compute_NTLM_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(NtlmAuthLevel), typeof(string), typeof(string), typeof(string), typeof(Byte[]&), typeof(Byte[]&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MD5), Member = "Create", ReturnType = typeof(MD5))]
	[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChallengeResponse2), Member = "Compute_NTLM_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ChallengeResponse2), Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void Compute_NTLMv2_Session(string password, Byte[] challenge, out Byte[] lm, out Byte[] ntlm) { }

	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_LM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2_Session", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(Byte[]&), typeof(Byte[]&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DES), Member = "Create", ReturnType = typeof(DES))]
	[Calls(Type = typeof(ChallengeResponse2), Member = "PrepareDESKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	private static Byte[] GetResponse(Byte[] challenge, Byte[] pwd) { }

	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_LM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChallengeResponse2), Member = "PrepareDESKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Byte[] PasswordToKey(string password, int position) { }

	[CalledBy(Type = typeof(ChallengeResponse2), Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(ChallengeResponse2), Member = "PasswordToKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte[] PrepareDESKey(Byte[] key56bits, int position) { }

}

