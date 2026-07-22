namespace TMPro;

[DebuggerDisplay("Item count = {m_Count}")]
public struct TMP_TextProcessingStack
{
	private const int k_DefaultCapacity = 4; //Field offset: 0x0
	public T[] itemStack; //Field offset: 0x0
	public int index; //Field offset: 0x0
	private T m_DefaultItem; //Field offset: 0x0
	private int m_Capacity; //Field offset: 0x0
	private int m_RolloverSize; //Field offset: 0x0
	private int m_Count; //Field offset: 0x0

	public int Count
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public T current
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 64
	}

	public int rolloverSize
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public TMP_TextProcessingStack`1(T[] stack) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public TMP_TextProcessingStack`1(int capacity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public TMP_TextProcessingStack`1(int capacity, int rolloverSize) { }

	[CallerCount(Count = 21)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Add(T item) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T CurrentItem() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T get_current() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_rolloverSize() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T Peek() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public T Pop() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T PreviousItem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public void Push(T item) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T Remove() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_rolloverSize(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void SetDefault(T item) { }

}

