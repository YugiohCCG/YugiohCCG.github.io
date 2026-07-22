namespace Unity.Hierarchy;

[IsReadOnly]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyFlattenedNode.h")]
public struct HierarchyFlattenedNode : IEquatable<HierarchyFlattenedNode>
{
	private static readonly HierarchyFlattenedNode s_Null; //Field offset: 0x0
	private readonly HierarchyNode m_Node; //Field offset: 0x0
	private readonly HierarchyNodeType m_Type; //Field offset: 0x8
	private readonly int m_ParentOffset; //Field offset: 0xC
	private readonly int m_NextSiblingOffset; //Field offset: 0x10
	private readonly int m_ChildrenCount; //Field offset: 0x14
	private readonly int m_Depth; //Field offset: 0x18

	public int ChildrenCount
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int NextSiblingOffset
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public HierarchyNode Node
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[IsReadOnly]
	public static HierarchyFlattenedNode Null
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 51
	}

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	public override bool Equals(HierarchyFlattenedNode other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_ChildrenCount() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_NextSiblingOffset() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public HierarchyNode get_Node() { }

	[CallerCount(Count = 0)]
	public static HierarchyFlattenedNode get_Null() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(int))]
	[ExcludeFromDocs]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal static HierarchyNode GetNodeByRef(in HierarchyFlattenedNode hierarchyFlattenedNode) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	public static bool op_Equality(in HierarchyFlattenedNode lhs, in HierarchyFlattenedNode rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[ExcludeFromDocs]
	public virtual string ToString() { }

}

