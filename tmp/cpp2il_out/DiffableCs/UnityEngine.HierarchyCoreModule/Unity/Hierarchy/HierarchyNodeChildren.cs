namespace Unity.Hierarchy;

[DefaultMember("Item")]
[IsReadOnly]
public struct HierarchyNodeChildren
{
	internal struct Enumerator
	{
		private readonly HierarchyNodeChildren m_Enumerable; //Field offset: 0x0
		private int m_Index; //Field offset: 0x18

		[IsReadOnly]
		public HierarchyNode Current
		{
			[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(HierarchyNodeChildren), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
			[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 5)]
			 get { } //Length: 246
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal Enumerator(in HierarchyNodeChildren enumerable) { }

		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(HierarchyNodeChildren), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		public HierarchyNode get_Current() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool MoveNext() { }

	}

	private readonly Hierarchy m_Hierarchy; //Field offset: 0x0
	private readonly HierarchyNode* m_Ptr; //Field offset: 0x8
	private readonly int m_Version; //Field offset: 0x10
	private readonly int m_Count; //Field offset: 0x14

	[CalledBy(Type = typeof(Hierarchy), Member = "EnumerateChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNodeChildren))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	internal HierarchyNodeChildren(Hierarchy hierarchy, IntPtr nodeChildrenPtr) { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIdsByIndex>d__41", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetChildIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public Enumerator GetEnumerator() { }

	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 20)]
	private void ThrowIfVersionChanged() { }

}

