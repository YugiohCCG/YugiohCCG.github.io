namespace UnityEngine.Bindings;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[VisibleToOtherModules]
internal struct BlittableArrayWrapper
{
	public enum UpdateFlags
	{
		NoUpdateNeeded = 0,
		SizeChanged = 1,
		DataIsNativePointer = 2,
		DataIsNativeOwnedMemory = 3,
		DataIsEmpty = 4,
		DataIsNull = 5,
	}

	internal Void* data; //Field offset: 0x0
	internal int size; //Field offset: 0x8
	internal UpdateFlags updateFlags; //Field offset: 0xC

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BlittableArrayWrapper(Void* data, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingsAllocator), Member = "FreeNativeOwnedMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	internal void Unmarshal(ref T[] array) { }

}

