namespace UnityEngine.UIElements;

[DefaultMember("Item")]
[UxmlObject]
public class SortColumnDescriptions : ICollection<SortColumnDescription>, IEnumerable<SortColumnDescription>, IEnumerable
{
	[Obsolete("UxmlObjectFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	public class UxmlObjectFactory : UxmlObjectFactory<SortColumnDescriptions>
	{

		[CalledBy(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		public UxmlObjectFactory() { }

	}

	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	public class UxmlObjectFactory : UxmlObjectFactory<T, UxmlObjectTraits`1<T>>
	{

		[CallerCount(Count = 4)]
		[Calls(Type = typeof(BaseUxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UxmlObjectFactory`1() { }

	}

	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	public class UxmlObjectTraits : UxmlObjectTraits<T>
	{
		private readonly UxmlObjectListAttributeDescription<SortColumnDescription> m_SortColumnDescriptions; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public UxmlObjectTraits`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SortColumnDescriptions), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescription)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	}

	[SerializeField]
	private readonly IList<SortColumnDescription> m_Descriptions; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action changed; //Field offset: 0x18

	internal event Action changed
	{
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 146
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 146
	}

	public override int Count
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 70
	}

	public override bool IsReadOnly
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 73
	}

	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public SortColumnDescriptions() { }

	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SortColumnDescription)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void Add(SortColumnDescription item) { }

	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void add_changed(Action value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public override void Clear() { }

	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override bool Contains(SortColumnDescription item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void CopyTo(SortColumnDescription[] array, int arrayIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override int get_Count() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override bool get_IsReadOnly() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override IEnumerator<SortColumnDescription> GetEnumerator() { }

	[CalledBy(Type = typeof(SortColumnDescriptions), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescription)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public void Insert(int index, SortColumnDescription desc) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnDescriptionChanged(SortColumnDescription desc) { }

	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public override bool Remove(SortColumnDescription desc) { }

	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void remove_changed(Action value) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

