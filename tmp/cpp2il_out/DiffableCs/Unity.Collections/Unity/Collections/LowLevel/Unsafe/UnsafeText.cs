namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
public struct UnsafeText : INativeDisposable, IDisposable, IUTF8Bytes, INativeList<Byte>, IIndexable<Byte>
{
	public const int MaxCapacity = 2147483646; //Field offset: 0x0
	internal UntypedUnsafeList m_UntypedListData; //Field offset: 0x0

	public override int Capacity
	{
		[CallerCount(Count = 0)]
		[IsReadOnly]
		 get { } //Length: 77
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		 set { } //Length: 99
	}

	public bool IsCreated
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[IsReadOnly]
		 get { } //Length: 80
	}

	public override bool IsEmpty
	{
		[CalledBy(Type = typeof(ReadOnly), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(NativeText), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[IsReadOnly]
		 get { } //Length: 171
	}

	public override byte Item
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 62
		[CallerCount(Count = 0)]
		 set { } //Length: 75
	}

	public override int Length
	{
		[CallerCount(Count = 0)]
		[IsReadOnly]
		 get { } //Length: 77
		[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeText), Member = "TryResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(NativeText), Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeText), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeText), Member = "Clear", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
		 set { } //Length: 151
	}

	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(AllocatorHandle)}, ReturnType = typeof(UnsafeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(AllocatorHandle), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(UnsafeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(AllocatorHandle)}, ReturnType = typeof(UnsafeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(AllocatorHandle), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(UnsafeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(AllocatorHandle)}, ReturnType = typeof(UnsafeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(AllocatorHandle), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(UnsafeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "ToLowerAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(AllocatorHandle)}, ReturnType = typeof(UnsafeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "ToUpperAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(AllocatorHandle)}, ReturnType = typeof(UnsafeText))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public UnsafeText(int capacity, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static UnsafeText* Alloc(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckCapacityInRange(int value, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 9)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void CheckIndexInRange(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[CallerCount(Count = 0)]
	public override byte ElementAt(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void Free(UnsafeText* data) { }

	[CallerCount(Count = 0)]
	[IsReadOnly]
	public override int get_Capacity() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CalledBy(Type = typeof(ReadOnly), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public override bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	public override byte get_Item(int index) { }

	[CallerCount(Count = 0)]
	[IsReadOnly]
	public override int get_Length() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public override Byte* GetUnsafePtr() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public override void set_Capacity(int value) { }

	[CallerCount(Count = 0)]
	public override void set_Item(int index, byte value) { }

	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = "TryResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeText), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	public override void set_Length(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void ThrowCopyError(CopyError error, string source) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&)}, ReturnType = typeof(string))]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	public override bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

}

