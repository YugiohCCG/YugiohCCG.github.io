namespace UnityEngine.UIElements;

public class MultiColumnListView : BaseListView
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<MultiColumnListView, UxmlTraits>
	{

		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlEnumAttributeDescription<ColumnSortingMode> m_SortingMode; //Field offset: 0x108
		private readonly UxmlObjectAttributeDescription<Columns> m_Columns; //Field offset: 0x110
		private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions; //Field offset: 0x118

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlAttributeDescription), Member = "set_obsoleteNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		public UxmlTraits() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBagAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(String&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(MultiColumnListView), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
		[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SortColumnDescriptions), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(MultiColumnListView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private static readonly BindingId columnsProperty; //Field offset: 0x0
	private static readonly BindingId sortColumnDescriptionsProperty; //Field offset: 0x98
	private static readonly BindingId sortingModeProperty; //Field offset: 0x130
	private Columns m_Columns; //Field offset: 0x6B0
	private ColumnSortingMode m_SortingMode; //Field offset: 0x6B8
	private SortColumnDescriptions m_SortColumnDescriptions; //Field offset: 0x6C0
	private List<SortColumnDescription> m_SortedColumns; //Field offset: 0x6C8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action columnSortingChanged; //Field offset: 0x6D0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; //Field offset: 0x6D8

	[CreateProperty]
	public private Columns columns
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(EventHandler`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Columns), Member = "remove_propertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<UnityEngine.UIElements.BindablePropertyChangedEventArgs>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Columns), Member = "add_propertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<UnityEngine.UIElements.BindablePropertyChangedEventArgs>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Columns), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "GetOrCreateViewController", ReturnType = typeof(CollectionViewController))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Columns), Member = "Clear", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 371
	}

	[CreateProperty]
	public private SortColumnDescriptions sortColumnDescriptions
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
		[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SortColumnDescriptions), Member = "Clear", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 270
	}

	[CreateProperty]
	public ColumnSortingMode sortingMode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
		[Calls(Type = typeof(MultiColumnController), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 178
	}

	public MultiColumnListViewController viewController
	{
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
		 get { } //Length: 123
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[CallsUnknownMethods(Count = 3)]
	private static MultiColumnListView() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Columns), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SortColumnDescriptions), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_viewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	public MultiColumnListView() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortColumnDescriptions), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_viewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnListView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public MultiColumnListView(Columns columns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void ColumnsChanged(object sender, BindablePropertyChangedEventArgs args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnListViewController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	protected virtual CollectionViewController CreateViewController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	virtual void CreateVirtualizationController() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Columns get_columns() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SortColumnDescriptions get_sortColumnDescriptions() { }

	[CallerCount(Count = 0)]
	public ColumnSortingMode get_sortingMode() { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	public MultiColumnListViewController get_viewController() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RaiseColumnSortingChanged() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventHandler`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "remove_propertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<UnityEngine.UIElements.BindablePropertyChangedEventArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "add_propertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<UnityEngine.UIElements.BindablePropertyChangedEventArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "GetOrCreateViewController", ReturnType = typeof(CollectionViewController))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void set_columns(Columns value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
	[Calls(Type = typeof(MultiColumnController), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_sortingMode(ColumnSortingMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
	[Calls(Type = typeof(MultiColumnController), Member = "remove_columnSortingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "remove_headerContextMenuPopulateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.ContextualMenuPopulateEvent, UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "add_columnSortingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "add_headerContextMenuPopulateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.ContextualMenuPopulateEvent, UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetViewController(CollectionViewController controller) { }

}

