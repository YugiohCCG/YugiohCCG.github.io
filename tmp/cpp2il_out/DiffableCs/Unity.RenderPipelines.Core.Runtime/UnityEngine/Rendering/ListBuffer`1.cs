namespace UnityEngine.Rendering;

[DefaultMember("Item")]
public struct ListBuffer
{
	private T* m_BufferPtr; //Field offset: 0x0
	private int m_Capacity; //Field offset: 0x0
	private Int32* m_CountPtr; //Field offset: 0x0

	internal T* BufferPtr
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	public int Capacity
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int Count
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public T Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 398
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ListBuffer`1(T* bufferPtr, Int32* countPtr, int capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void CopyTo(T* dstBuffer, int startDstIndex, int copyCount) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	internal T* get_BufferPtr() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_Capacity() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public T get_Item(in int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T GetUnchecked(in int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public bool TryAdd(in T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public bool TryCopyFrom(T* srcPtr, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	public bool TryCopyTo(ListBuffer<T> other) { }

}

