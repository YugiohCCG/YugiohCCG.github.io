namespace System.Collections.Generic;

internal struct LargeArrayBuilder
{
	private readonly int _maxCapacity; //Field offset: 0x0
	private T[] _first; //Field offset: 0x0
	private ArrayBuilder<T[]> _buffers; //Field offset: 0x0
	private T[] _current; //Field offset: 0x0
	private int _index; //Field offset: 0x0
	private int _count; //Field offset: 0x0

	[CalledBy(Type = typeof(EnumerableHelpers), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public LargeArrayBuilder`1(bool initialize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public LargeArrayBuilder`1(int maxCapacity) { }

	[CalledBy(Type = typeof(EnumerableHelpers), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LargeArrayBuilder`1), Member = "AddWithBufferAllocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T[]&", typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	public void AddRange(IEnumerable<T> items) { }

	[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LargeArrayBuilder`1), Member = "AllocateBuffer", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private void AddWithBufferAllocation(T item, ref T[] destination, ref int index) { }

	[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "AddWithBufferAllocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T[]&", typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private void AllocateBuffer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void CopyTo(T[] array, int arrayIndex, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T[] GetBuffer(int index) { }

	[CalledBy(Type = typeof(EnumerableHelpers), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public T[] ToArray() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool TryMove(out T[] array) { }

}

