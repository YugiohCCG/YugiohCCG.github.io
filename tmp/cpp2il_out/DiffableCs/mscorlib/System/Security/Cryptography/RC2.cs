namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class RC2 : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8
	protected int EffectiveKeySizeValue; //Field offset: 0x48

	public override int EffectiveKeySize
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
	}

	public virtual int KeySize
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 126
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static RC2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected RC2() { }

	[CallerCount(Count = 0)]
	public override int get_EffectiveKeySize() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual int get_KeySize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void set_KeySize(int value) { }

}

