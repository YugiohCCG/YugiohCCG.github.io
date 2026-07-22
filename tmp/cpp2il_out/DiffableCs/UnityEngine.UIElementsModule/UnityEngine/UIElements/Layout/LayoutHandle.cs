namespace UnityEngine.UIElements.Layout;

[IsReadOnly]
internal struct LayoutHandle
{
	public readonly int Index; //Field offset: 0x0
	public readonly int Version; //Field offset: 0x4

	public static LayoutHandle Undefined
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	internal LayoutHandle(int index, int version) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Equals(LayoutHandle other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public static LayoutHandle get_Undefined() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}

