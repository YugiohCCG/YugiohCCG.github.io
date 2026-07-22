namespace UnityEngine.Rendering.Universal;

[DefaultMember("Item")]
internal struct Fixed2
{
	public T item1; //Field offset: 0x0
	public T item2; //Field offset: 0x0

	public T Item
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Fixed2`1(T item1) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public Fixed2`1(T item1, T item2) { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private static void CheckRange(int index) { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public T get_Item(int index) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Item(int index, T value) { }

}

