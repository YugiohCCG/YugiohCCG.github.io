namespace UnityEngine.UIElements.UIR;

internal class EntryPreProcessor
{
	internal struct AllocSize
	{
		public int vertexCount; //Field offset: 0x0
		public int indexCount; //Field offset: 0x4

	}

	private int m_ChildrenIndex; //Field offset: 0x10
	private List<AllocSize> m_Allocs; //Field offset: 0x18
	private List<AllocSize> m_HeadAllocs; //Field offset: 0x20
	private List<AllocSize> m_TailAllocs; //Field offset: 0x28
	private List<Entry> m_FlattenedEntries; //Field offset: 0x30
	private AllocSize m_Pending; //Field offset: 0x38
	private Stack<AllocSize> m_Mask; //Field offset: 0x40
	private bool m_IsPushingMask; //Field offset: 0x48

	public int childrenIndex
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public List<Entry> flattenedEntries
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public List<AllocSize> headAllocs
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public List<AllocSize> tailAllocs
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public EntryPreProcessor() { }

	[CalledBy(Type = typeof(EntryPreProcessor), Member = "PreProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryPreProcessor), Member = "DoEvaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Add(int vertexCount, int indexCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ClearReferences() { }

	[CalledBy(Type = typeof(EntryPreProcessor), Member = "PreProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryPreProcessor), Member = "DoEvaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryPreProcessor), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryPreProcessor), Member = "DoEvaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "TryPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private void DoEvaluate(Entry entry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Flush() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_childrenIndex() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public List<Entry> get_flattenedEntries() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public List<AllocSize> get_headAllocs() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public List<AllocSize> get_tailAllocs() { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryPreProcessor), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryPreProcessor), Member = "DoEvaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "TryPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public void PreProcess(Entry root) { }

}

