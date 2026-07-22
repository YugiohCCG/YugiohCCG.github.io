namespace System.Runtime.Serialization;

internal class ObjectHolderList
{
	internal ObjectHolder[] m_values; //Field offset: 0x10
	internal int m_count; //Field offset: 0x18

	internal int Count
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal int Version
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ObjectHolderList() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ObjectHolderList(int startingSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal override void Add(ObjectHolder value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void EnlargeArray() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_Count() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_Version() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

}

