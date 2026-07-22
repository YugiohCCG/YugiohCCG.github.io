namespace Unity.Hierarchy;

[IsReadOnly]
public struct HierarchyViewNodesEnumerable
{
	internal struct Enumerator
	{
		private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x0
		private readonly Predicate m_Predicate; //Field offset: 0x8
		private readonly HierarchyNodeFlags m_Flags; //Field offset: 0x10
		private readonly HierarchyFlattenedNode* m_NodesPtr; //Field offset: 0x18
		private readonly int m_NodesCount; //Field offset: 0x20
		private readonly int m_Version; //Field offset: 0x24
		private int m_Index; //Field offset: 0x28

		[IsReadOnly]
		public HierarchyNode Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Enumerator), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
			 get { } //Length: 34
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal Enumerator(HierarchyViewNodesEnumerable enumerable) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerator), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
		public HierarchyNode get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerator), Member = "ThrowIfVersionChanged", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public bool MoveNext() { }

		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
		[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Memory`1<System.IntPtr>), Member = "get_Span", ReturnType = typeof(System.Span`1<System.IntPtr>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		private void ThrowIfVersionChanged() { }

	}

	public sealed class Predicate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public Predicate(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override bool Invoke(in HierarchyNode node, HierarchyNodeFlags flags) { }

	}

	private readonly HierarchyViewModel m_HierarchyViewModel; //Field offset: 0x0
	private readonly Predicate m_Predicate; //Field offset: 0x8
	private readonly HierarchyNodeFlags m_Flags; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal HierarchyViewNodesEnumerable(HierarchyViewModel viewModel, HierarchyNodeFlags flags, Predicate predicate) { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Int32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public Enumerator GetEnumerator() { }

}

