namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/Public/HierarchyPropertyDescriptor.h")]
public struct HierarchyPropertyDescriptor
{
	private int m_Size; //Field offset: 0x0
	private HierarchyPropertyStorageType m_Type; //Field offset: 0x4

	public int Size
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public HierarchyPropertyStorageType Type
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_Size(int value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void set_Type(HierarchyPropertyStorageType value) { }

}

