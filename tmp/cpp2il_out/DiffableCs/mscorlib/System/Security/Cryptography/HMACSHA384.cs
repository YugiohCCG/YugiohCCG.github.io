namespace System.Security.Cryptography;

[ComVisible(True)]
public class HMACSHA384 : HMAC
{
	private bool m_useLegacyBlockSize; //Field offset: 0x68

	private int BlockSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 18
	}

	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SHA384Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public HMACSHA384() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA384Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public HMACSHA384(Byte[] key) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private int get_BlockSize() { }

}

