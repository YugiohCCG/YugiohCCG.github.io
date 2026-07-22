namespace Mono.Security.Protocol.Ntlm;

public class Type2Message : MessageBase
{
	private Byte[] _nonce; //Field offset: 0x18
	private string _targetName; //Field offset: 0x20
	private Byte[] _targetInfo; //Field offset: 0x28

	public Byte[] Nonce
	{
		[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(NtlmAuthLevel), typeof(string), typeof(string), typeof(string), typeof(Byte[]&), typeof(Byte[]&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 119
	}

	public Byte[] TargetInfo
	{
		[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 119
	}

	public string TargetName
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Type2Message(Byte[] message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageBase), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitConverterLE), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Decode(Byte[] message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(NtlmAuthLevel), typeof(string), typeof(string), typeof(string), typeof(Byte[]&), typeof(Byte[]&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Byte[] get_Nonce() { }

	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Byte[] get_TargetInfo() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_TargetName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageBase), Member = "PrepareMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual Byte[] GetBytes() { }

}

