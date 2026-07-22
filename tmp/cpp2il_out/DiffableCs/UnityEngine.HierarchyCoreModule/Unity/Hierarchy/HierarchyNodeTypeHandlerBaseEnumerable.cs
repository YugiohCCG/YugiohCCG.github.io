namespace Unity.Hierarchy;

[IsReadOnly]
public struct HierarchyNodeTypeHandlerBaseEnumerable
{
	internal struct Enumerator : IDisposable
	{
		private readonly IMemoryOwner<IntPtr> m_Handlers; //Field offset: 0x0
		private readonly int m_Count; //Field offset: 0x8
		private int m_Index; //Field offset: 0xC

		public HierarchyNodeTypeHandlerBase Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(System.Memory`1<System.IntPtr>), Member = "get_Span", ReturnType = typeof(System.Span`1<System.IntPtr>))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			 get { } //Length: 289
		}

		[CalledBy(Type = typeof(HierarchyNodeTypeHandlerBaseEnumerable), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[CalledBy(Type = typeof(HierarchyViewModel), Member = "SearchBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Memory`1<System.IntPtr>), Member = "get_Span", ReturnType = typeof(System.Span`1<System.IntPtr>))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 11)]
		internal Enumerator(Hierarchy hierarchy) { }

		[CalledBy(Type = typeof(HierarchyViewModel), Member = "SearchBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Memory`1<System.IntPtr>), Member = "get_Span", ReturnType = typeof(System.Span`1<System.IntPtr>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public HierarchyNodeTypeHandlerBase get_Current() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool MoveNext() { }

	}

	private readonly Hierarchy m_Hierarchy; //Field offset: 0x0

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal HierarchyNodeTypeHandlerBaseEnumerable(Hierarchy hierarchy) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	public Enumerator GetEnumerator() { }

}

