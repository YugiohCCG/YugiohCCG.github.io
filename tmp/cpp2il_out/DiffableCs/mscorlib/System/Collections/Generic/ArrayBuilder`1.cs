namespace System.Collections.Generic;

[DefaultMember("Item")]
internal struct ArrayBuilder
{
	private T[] _array; //Field offset: 0x0
	private int _count; //Field offset: 0x0

	public int Capacity
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	public int Count
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public T Item
	{
		[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "GetBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T[]")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "AllocateBuffer", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public void Add(T item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private void EnsureCapacity(int minimum) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_Capacity() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "GetBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T[]")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T get_Item(int index) { }

	[CallerCount(Count = 30)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void UncheckedAdd(T item) { }

}

