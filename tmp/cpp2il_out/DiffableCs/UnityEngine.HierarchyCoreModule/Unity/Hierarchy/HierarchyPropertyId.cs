namespace Unity.Hierarchy;

[IsReadOnly]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyPropertyId.h")]
internal struct HierarchyPropertyId : IEquatable<HierarchyPropertyId>
{
	private static readonly HierarchyPropertyId s_Null; //Field offset: 0x0
	private readonly int m_Id; //Field offset: 0x0

	public int Id
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[IsReadOnly]
	public static HierarchyPropertyId Null
	{
		[CalledBy(Type = typeof(HierarchyPropertyUnmanaged`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy), typeof(HierarchyPropertyId&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 51
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public HierarchyPropertyId() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(HierarchyPropertyId other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public int get_Id() { }

	[CalledBy(Type = typeof(HierarchyPropertyUnmanaged`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy), typeof(HierarchyPropertyId&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public static HierarchyPropertyId get_Null() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(in HierarchyPropertyId lhs, in HierarchyPropertyId rhs) { }

	[CalledBy(Type = typeof(HierarchyPropertyUnmanaged`1), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

