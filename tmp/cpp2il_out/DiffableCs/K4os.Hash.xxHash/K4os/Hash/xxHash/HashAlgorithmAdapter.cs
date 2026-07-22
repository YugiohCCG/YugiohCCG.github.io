namespace K4os.Hash.xxHash;

public class HashAlgorithmAdapter : HashAlgorithm
{
	private readonly Action _reset; //Field offset: 0x28
	private readonly Action<Byte[], Int32, Int32> _update; //Field offset: 0x30
	private readonly Func<Byte[]> _digest; //Field offset: 0x38
	[CompilerGenerated]
	private readonly int <HashSize>k__BackingField; //Field offset: 0x40

	public virtual Byte[] Hash
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 34
	}

	public virtual int HashSize
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public HashAlgorithmAdapter(int hashSize, Action reset, Action<Byte[], Int32, Int32> update, Func<Byte[]> digest) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Byte[] get_Hash() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual int get_HashSize() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void HashCore(Byte[] array, int ibStart, int cbSize) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual Byte[] HashFinal() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Initialize() { }

}

