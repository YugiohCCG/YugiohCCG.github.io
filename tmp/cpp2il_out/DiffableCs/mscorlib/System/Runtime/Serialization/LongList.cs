namespace System.Runtime.Serialization;

internal class LongList
{
	private Int64[] m_values; //Field offset: 0x10
	private int m_count; //Field offset: 0x18
	private int m_totalItems; //Field offset: 0x1C
	private int m_currentItem; //Field offset: 0x20

	internal int Count
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal long Current
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 43
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal LongList() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal LongList(int startingSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void Add(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void EnlargeArray() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_Count() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal long get_Current() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool MoveNext() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal bool RemoveElement(long value) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	internal void StartEnumeration() { }

}

