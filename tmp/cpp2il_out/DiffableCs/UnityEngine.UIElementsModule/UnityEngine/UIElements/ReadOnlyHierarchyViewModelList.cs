namespace UnityEngine.UIElements;

[DefaultMember("Item")]
internal class ReadOnlyHierarchyViewModelList : IList, ICollection, IEnumerable
{
	private struct Enumerator : IEnumerator
	{
		private readonly HierarchyViewModel m_HierarchyViewModel; //Field offset: 0x0
		private Enumerator m_Enumerator; //Field offset: 0x8

		public override object Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 5)]
			 get { } //Length: 191
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyViewModel), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[CallsUnknownMethods(Count = 3)]
		public Enumerator(HierarchyViewModel hierarchyViewModel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public override object get_Current() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyViewModel), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[CallsUnknownMethods(Count = 2)]
		public override void Reset() { }

	}

	private readonly HierarchyViewModel m_HierarchyViewModel; //Field offset: 0x10

	public override int Count
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 26
	}

	public override bool IsFixedSize
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsReadOnly
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsSynchronized
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
	}

	public override object Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 62
	}

	public override object SyncRoot
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnlyHierarchyViewModelList(HierarchyViewModel viewModel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override int Add(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HierarchyViewModel), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public override bool Contains(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override void CopyTo(Array array, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override int get_Count() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_IsFixedSize() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override bool get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[CallsUnknownMethods(Count = 1)]
	public override object get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override object get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HierarchyViewModel), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
	[CallsUnknownMethods(Count = 3)]
	public override IEnumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HierarchyViewModel), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public override int IndexOf(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void Insert(int index, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void Remove(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void RemoveAt(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void set_Item(int index, object value) { }

}

