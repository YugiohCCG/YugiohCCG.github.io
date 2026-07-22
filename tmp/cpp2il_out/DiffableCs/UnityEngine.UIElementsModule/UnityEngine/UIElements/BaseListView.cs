namespace UnityEngine.UIElements;

public abstract class BaseListView : BaseVerticalCollectionView
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public BaseListView <>4__this; //Field offset: 0x10
		public int itemsCountPreCallback; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass82_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseListView), Member = "OnAfterAddClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <OnAddClicked>b__0() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader; //Field offset: 0xC8
		private readonly UxmlStringAttributeDescription m_HeaderTitle; //Field offset: 0xD0
		private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter; //Field offset: 0xD8
		private readonly UxmlBoolAttributeDescription m_AllowAdd; //Field offset: 0xE0
		private readonly UxmlBoolAttributeDescription m_AllowRemove; //Field offset: 0xE8
		private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode; //Field offset: 0xF0
		private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize; //Field offset: 0xF8
		private readonly UxmlEnumAttributeDescription<BindingSourceSelectionMode> m_BindingSourceSelectionMode; //Field offset: 0x100

		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 18)]
		protected UxmlTraits() { }

		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_reorderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListViewReorderMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_headerTitle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_showAddRemoveFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_allowAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_allowRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_showBoundCollectionSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_bindingSourceSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingSourceSelectionMode)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private static readonly string k_SizeFieldLabel; //Field offset: 0x0
	internal static readonly BindingId showBoundCollectionSizeProperty; //Field offset: 0x8
	internal static readonly BindingId showFoldoutHeaderProperty; //Field offset: 0xA0
	internal static readonly BindingId headerTitleProperty; //Field offset: 0x138
	internal static readonly BindingId makeHeaderProperty; //Field offset: 0x1D0
	internal static readonly BindingId makeFooterProperty; //Field offset: 0x268
	internal static readonly BindingId showAddRemoveFooterProperty; //Field offset: 0x300
	internal static readonly BindingId bindingSourceSelectionModeProperty; //Field offset: 0x398
	internal static readonly BindingId reorderModeProperty; //Field offset: 0x430
	internal static readonly BindingId makeNoneElementProperty; //Field offset: 0x4C8
	internal static readonly BindingId allowAddProperty; //Field offset: 0x560
	internal static readonly BindingId overridingAddButtonBehaviorProperty; //Field offset: 0x5F8
	internal static readonly BindingId onAddProperty; //Field offset: 0x690
	internal static readonly BindingId allowRemoveProperty; //Field offset: 0x728
	internal static readonly BindingId onRemoveProperty; //Field offset: 0x7C0
	public static readonly string ussClassName; //Field offset: 0x858
	public static readonly string itemUssClassName; //Field offset: 0x860
	public static readonly string emptyLabelUssClassName; //Field offset: 0x868
	public static readonly string overMaxMultiEditLimitClassName; //Field offset: 0x870
	public static readonly string reorderableUssClassName; //Field offset: 0x878
	public static readonly string reorderableItemUssClassName; //Field offset: 0x880
	public static readonly string reorderableItemContainerUssClassName; //Field offset: 0x888
	public static readonly string reorderableItemHandleUssClassName; //Field offset: 0x890
	public static readonly string reorderableItemHandleBarUssClassName; //Field offset: 0x898
	public static readonly string footerUssClassName; //Field offset: 0x8A0
	public static readonly string foldoutHeaderUssClassName; //Field offset: 0x8A8
	public static readonly string arraySizeFieldUssClassName; //Field offset: 0x8B0
	public static readonly string arraySizeFieldWithHeaderUssClassName; //Field offset: 0x8B8
	public static readonly string arraySizeFieldWithFooterUssClassName; //Field offset: 0x8C0
	public static readonly string listViewWithHeaderUssClassName; //Field offset: 0x8C8
	public static readonly string listViewWithFooterUssClassName; //Field offset: 0x8D0
	public static readonly string scrollViewWithFooterUssClassName; //Field offset: 0x8D8
	public static readonly string footerAddButtonName; //Field offset: 0x8E0
	public static readonly string footerRemoveButtonName; //Field offset: 0x8E8
	private static readonly string k_EmptyListStr; //Field offset: 0x8F0
	private bool m_ShowBoundCollectionSize; //Field offset: 0x5A0
	private bool m_ShowFoldoutHeader; //Field offset: 0x5A1
	private string m_HeaderTitle; //Field offset: 0x5A8
	private VisualElement drawnHeader; //Field offset: 0x5B0
	private Func<VisualElement> m_MakeHeader; //Field offset: 0x5B8
	private VisualElement drawnFooter; //Field offset: 0x5C0
	private Func<VisualElement> m_MakeFooter; //Field offset: 0x5C8
	private bool m_ShowAddRemoveFooter; //Field offset: 0x5D0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Int32>> itemsAdded; //Field offset: 0x5D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Int32>> itemsRemoved; //Field offset: 0x5E0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action itemsSourceSizeChanged; //Field offset: 0x5E8
	private IVisualElementScheduledItem m_TrackedItem; //Field offset: 0x5F0
	private Action m_TrackCount; //Field offset: 0x5F8
	private Func<Boolean> m_WhileAutoAssign; //Field offset: 0x600
	private BindingSourceSelectionMode m_BindingSourceSelectionMode; //Field offset: 0x608
	private Label m_ListViewLabel; //Field offset: 0x610
	private Foldout m_Foldout; //Field offset: 0x618
	private TextField m_ArraySizeField; //Field offset: 0x620
	private bool m_IsOverMultiEditLimit; //Field offset: 0x628
	private VisualElement m_Footer; //Field offset: 0x630
	private Button m_AddButton; //Field offset: 0x638
	private Button m_RemoveButton; //Field offset: 0x640
	private Action<IEnumerable`1<Int32>> m_ItemAddedCallback; //Field offset: 0x648
	private Action<IEnumerable`1<Int32>> m_ItemRemovedCallback; //Field offset: 0x650
	private Action m_ItemsSourceSizeChangedCallback; //Field offset: 0x658
	private ListViewReorderMode m_ReorderMode; //Field offset: 0x660
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action reorderModeChanged; //Field offset: 0x668
	private VisualElement m_NoneElement; //Field offset: 0x670
	private Func<VisualElement> m_MakeNoneElement; //Field offset: 0x678
	private bool m_AllowAdd; //Field offset: 0x680
	private Action<BaseListView, Button> m_OverridingAddButtonBehavior; //Field offset: 0x688
	private Action<BaseListView> m_OnAdd; //Field offset: 0x690
	private bool m_AllowRemove; //Field offset: 0x698
	private Action<BaseListView> m_OnRemove; //Field offset: 0x6A0
	private string m_MaxMultiEditStr; //Field offset: 0x6A8

	internal event Action reorderModeChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 146
	}

	[CreateProperty]
	public bool allowAdd
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 151
	}

	[CreateProperty]
	public bool allowRemove
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BaseListView), Member = "UpdateRemoveButton", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 137
	}

	internal bool autoAssignSource
	{
		[CalledBy(Type = typeof(ListView), Member = "HasValidDataAndBindings", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 11
	}

	[CreateProperty]
	public BindingSourceSelectionMode bindingSourceSelectionMode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "get_trackItemCount", ReturnType = typeof(IVisualElementScheduledItem))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 195
	}

	internal VisualElement footer
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
	}

	[CreateProperty]
	public string headerTitle
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Foldout), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 204
	}

	[CreateProperty]
	public Func<VisualElement> makeFooter
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "BringToFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 581
	}

	[CreateProperty]
	public Func<VisualElement> makeHeader
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "SendToBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 687
	}

	[CreateProperty]
	public Func<VisualElement> makeNoneElement
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 213
	}

	[CreateProperty]
	public Action<BaseListView> onAdd
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 165
	}

	[CreateProperty]
	public Action<BaseListView> onRemove
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 165
	}

	[CreateProperty]
	public Action<BaseListView, Button> overridingAddButtonBehavior
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 165
	}

	[CreateProperty]
	public ListViewReorderMode reorderMode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "InitializeDragAndDropController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 181
	}

	[CreateProperty]
	public bool showAddRemoveFooter
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 12
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 267
	}

	[CreateProperty]
	public bool showBoundCollectionSize
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 134
	}

	[CreateProperty]
	public bool showFoldoutHeader
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "RemoveFoldout", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "BringToFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 551
	}

	private Action trackCount
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 138
	}

	private IVisualElementScheduledItem trackItemCount
	{
		[CalledBy(Type = typeof(BaseListView), Member = "set_bindingSourceSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingSourceSelectionMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		private get { } //Length: 514
	}

	private Func<Boolean> untilManualBindingSourceSelectionMode
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 138
	}

	public BaseListViewController viewController
	{
		[CalledBy(Type = typeof(BaseListView), Member = "OnArraySizeFieldChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.String>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "UpdateRemoveButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "UpdateArraySizeField", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "OnRemoveClicked", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "PostRefresh", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
		[CalledBy(Type = typeof(ListViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 21)]
		 get { } //Length: 117
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 35)]
	private static BaseListView() { }

	[CalledBy(Type = typeof(BaseListView), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public BaseListView(IList itemsSource, float itemHeight = -1) { }

	[CalledBy(Type = typeof(ListView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(float)}, ReturnType = typeof(void))]
	public BaseListView() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	private void <get_trackCount>b__65_0() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	private bool <get_untilManualBindingSourceSelectionMode>b__68_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void add_reorderModeChanged(Action value) { }

	[CalledBy(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Foldout), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void AddFoldout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "GetOrCreateViewController", ReturnType = typeof(CollectionViewController))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void AddItems(int itemCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewReorderableDragAndDropController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseListView)}, ReturnType = typeof(void))]
	internal virtual ICollectionDragAndDropController CreateDragAndDropController() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal virtual ListViewDragger CreateDragger() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	virtual void CreateVirtualizationController() { }

	[CalledBy(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_showAddRemoveFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "UpdateRemoveButton", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void EnableFooter(bool enabled) { }

	[CallerCount(Count = 0)]
	public bool get_allowAdd() { }

	[CallerCount(Count = 0)]
	public bool get_allowRemove() { }

	[CalledBy(Type = typeof(ListView), Member = "HasValidDataAndBindings", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_autoAssignSource() { }

	[CallerCount(Count = 0)]
	public BindingSourceSelectionMode get_bindingSourceSelectionMode() { }

	[CallerCount(Count = 0)]
	internal VisualElement get_footer() { }

	[CallerCount(Count = 0)]
	public string get_headerTitle() { }

	[CallerCount(Count = 0)]
	public Func<VisualElement> get_makeFooter() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Func<VisualElement> get_makeHeader() { }

	[CallerCount(Count = 0)]
	public Func<VisualElement> get_makeNoneElement() { }

	[CallerCount(Count = 0)]
	public Action<BaseListView> get_onAdd() { }

	[CallerCount(Count = 0)]
	public Action<BaseListView> get_onRemove() { }

	[CallerCount(Count = 0)]
	public Action<BaseListView, Button> get_overridingAddButtonBehavior() { }

	[CallerCount(Count = 0)]
	public ListViewReorderMode get_reorderMode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_showAddRemoveFooter() { }

	[CallerCount(Count = 0)]
	public bool get_showBoundCollectionSize() { }

	[CallerCount(Count = 0)]
	public bool get_showFoldoutHeader() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Action get_trackCount() { }

	[CalledBy(Type = typeof(BaseListView), Member = "set_bindingSourceSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingSourceSelectionMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private IVisualElementScheduledItem get_trackItemCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Func<Boolean> get_untilManualBindingSourceSelectionMode() { }

	[CalledBy(Type = typeof(BaseListView), Member = "OnArraySizeFieldChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "UpdateRemoveButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "UpdateArraySizeField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "OnRemoveClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "PostRefresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
	[CalledBy(Type = typeof(ListViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	public BaseListViewController get_viewController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedIndices", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Int32>))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Foldout), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	virtual bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "GetOrCreateViewController", ReturnType = typeof(CollectionViewController))]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "set_showMixedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	private void OnAddClicked() { }

	[CalledBy(Type = typeof(<>c__DisplayClass82_0), Member = "<OnAddClicked>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnAfterAddClicked(int itemsCountPreCallback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Calls(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	private void OnArraySizeFieldChanged(ChangeEvent<String> evt) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnItemAdded(IEnumerable<Int32> indices) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnItemsRemoved(IEnumerable<Int32> indices) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnItemsSourceSizeChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedIndices", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Int32>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Int32>))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "set_showMixedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void OnRemoveClicked() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseListView), Member = "UpdateArraySizeField", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "PostRefresh", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	virtual void PostRefresh() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void remove_reorderModeChanged(Action value) { }

	[CalledBy(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveFoldout() { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_allowAdd(bool value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseListView), Member = "UpdateRemoveButton", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_allowRemove(bool value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "get_trackItemCount", ReturnType = typeof(IVisualElementScheduledItem))]
	[CallsUnknownMethods(Count = 2)]
	public void set_bindingSourceSelectionMode(BindingSourceSelectionMode value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Foldout), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_headerTitle(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "BringToFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void set_makeFooter(Func<VisualElement> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "SendToBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void set_makeHeader(Func<VisualElement> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_makeNoneElement(Func<VisualElement> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_onAdd(Action<BaseListView> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_onRemove(Action<BaseListView> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_overridingAddButtonBehavior(Action<BaseListView, Button> value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "InitializeDragAndDropController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_reorderMode(ListViewReorderMode value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_showAddRemoveFooter(bool value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_showBoundCollectionSize(bool value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "RemoveFoldout", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "BringToFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_showFoldoutHeader(bool value) { }

	[CalledBy(Type = typeof(BaseListView), Member = "set_showBoundCollectionSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "set_label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_isDelayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "RegisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "UpdateArraySizeField", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextField), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void SetupArraySizeField() { }

	[CalledBy(Type = typeof(MultiColumnListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(BaseListViewController), Member = "add_itemsSourceSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	public virtual void SetViewController(CollectionViewController controller) { }

	[CalledBy(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "PostRefresh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void UpdateArraySizeField() { }

	[CalledBy(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "OnArraySizeFieldChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "PostRefresh", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	internal void UpdateListViewLabel() { }

	[CalledBy(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_allowRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void UpdateRemoveButton() { }

}

