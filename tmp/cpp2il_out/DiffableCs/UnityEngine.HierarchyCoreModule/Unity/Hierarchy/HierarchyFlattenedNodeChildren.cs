namespace Unity.Hierarchy;

[DefaultMember("Item")]
[IsReadOnly]
public struct HierarchyFlattenedNodeChildren
{
	internal struct Enumerator
	{
		private readonly HierarchyFlattenedNodeChildren m_Enumerable; //Field offset: 0x0
		private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x18
		private readonly HierarchyNode m_Node; //Field offset: 0x20
		private int m_CurrentIndex; //Field offset: 0x28
		private int m_ChildrenIndex; //Field offset: 0x2C
		private int m_ChildrenCount; //Field offset: 0x30

		[IsReadOnly]
		public HierarchyNode Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(HierarchyFlattenedNodeChildren), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
			[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 46
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal Enumerator(HierarchyFlattenedNodeChildren enumerable, HierarchyNode node) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyFlattenedNodeChildren), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
		[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
		[CallsUnknownMethods(Count = 1)]
		public HierarchyNode get_Current() { }

		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(HierarchyFlattenedNodeChildren), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
		[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public bool MoveNext() { }

	}

	private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x0
	private readonly HierarchyNode m_Node; //Field offset: 0x8
	private readonly int m_Version; //Field offset: 0x10
	private readonly int m_Count; //Field offset: 0x14

	[CalledBy(Type = typeof(HierarchyFlattened), Member = "EnumerateChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyFlattenedNodeChildren))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	internal HierarchyFlattenedNodeChildren(HierarchyFlattened hierarchyFlattened, in HierarchyNode node) { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Enumerator GetEnumerator() { }

	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void ThrowIfVersionChanged() { }

}

