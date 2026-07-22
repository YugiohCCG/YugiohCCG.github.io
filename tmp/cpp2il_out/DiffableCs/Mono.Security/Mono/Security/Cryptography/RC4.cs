namespace Mono.Security.Cryptography;

public abstract class RC4 : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8

	public virtual Byte[] IV
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 50
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static RC4() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public RC4() { }

	[CalledBy(Type = typeof(PrivateKey), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static RC4 Create() { }

	[CallerCount(Count = 0)]
	public virtual Byte[] get_IV() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void set_IV(Byte[] value) { }

}

