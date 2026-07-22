namespace Unity.Hierarchy;

[IsReadOnly]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeType.h")]
public struct HierarchyNodeType : IEquatable<HierarchyNodeType>
{
	private static readonly HierarchyNodeType s_Null; //Field offset: 0x0
	private readonly int m_Id; //Field offset: 0x0

	public int Id
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[IsReadOnly]
	public static HierarchyNodeType Null
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 51
	}

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	public override bool Equals(HierarchyNodeType other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public int get_Id() { }

	[CallerCount(Count = 0)]
	public static HierarchyNodeType get_Null() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	public static bool op_Equality(in HierarchyNodeType lhs, in HierarchyNodeType rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[ExcludeFromDocs]
	public virtual string ToString() { }

}

