namespace System.Buffers;

public abstract class ArrayPool
{
	[CompilerGenerated]
	private static readonly ArrayPool<T> <Shared>k__BackingField; //Field offset: 0x0

	public static ArrayPool<T> Shared
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 153
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private static ArrayPool`1() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ArrayPool`1() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public static ArrayPool<T> get_Shared() { }

	public abstract T[] Rent(int minimumLength) { }

	public abstract void Return(T[] array, bool clearArray = false) { }

}

