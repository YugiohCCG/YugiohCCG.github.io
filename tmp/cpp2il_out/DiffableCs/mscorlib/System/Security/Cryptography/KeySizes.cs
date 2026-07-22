namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class KeySizes
{
	private int m_minSize; //Field offset: 0x10
	private int m_maxSize; //Field offset: 0x14
	private int m_skipSize; //Field offset: 0x18

	public int MaxSize
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int MinSize
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int SkipSize
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public KeySizes(int minSize, int maxSize, int skipSize) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_MaxSize() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_MinSize() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_SkipSize() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool IsLegal(int keySize) { }

	[CalledBy(Type = typeof(RC2Transform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RC2), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }

}

