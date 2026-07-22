namespace UnityEngine.UIElements;

public abstract class BaseTreeViewController : CollectionViewController
{
	[CompilerGenerated]
	private sealed class <GetAllItemIds>d__23 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private int <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		private IEnumerable<Int32> rootIds; //Field offset: 0x20
		public IEnumerable<Int32> <>3__rootIds; //Field offset: 0x28
		public BaseTreeViewController <>4__this; //Field offset: 0x30
		private Enumerator <>s__1; //Field offset: 0x38
		private HierarchyFlattenedNode <flattenedNode>5__2; //Field offset: 0x58
		private HierarchyNode <node>5__3; //Field offset: 0x74
		private IEnumerator<Int32> <>s__4; //Field offset: 0x80
		private int <id>5__5; //Field offset: 0x88
		private HierarchyNode <parentNode>5__6; //Field offset: 0x8C
		private HierarchyFlattenedNodeChildren <flattenedNodeChildren>5__7; //Field offset: 0x98
		private Enumerator <>s__8; //Field offset: 0xB0
		private HierarchyNode <node>5__9; //Field offset: 0xE8

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[CallerCount(Count = 2)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = "System.Linq.Expressions.Interpreter.TryCatchFinallyHandler", Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 6)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 1078
		}

		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <GetAllItemIds>d__23(int <>1__state) { }

		[CalledBy(Type = typeof(<GetAllItemIds>d__23), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
		[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HierarchyFlattened), Member = "EnumerateChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyFlattenedNodeChildren))]
		[Calls(Type = typeof(HierarchyFlattenedNodeChildren), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HierarchyFlattened), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyFlattenedNode&))]
		[Calls(Type = typeof(<GetAllItemIds>d__23), Member = "<>m__Finally1", ReturnType = typeof(void))]
		[Calls(Type = typeof(HierarchyFlattened), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 41)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Linq.Expressions.Interpreter.TryCatchFinallyHandler", Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CalledBy(Type = "UnityEngine.UIElements.BackgroundRepeat+PropertyBag+YProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetChildrenIds>d__25 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private int <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		private int id; //Field offset: 0x1C
		public int <>3__id; //Field offset: 0x20
		public BaseTreeViewController <>4__this; //Field offset: 0x28
		private HierarchyNode <nodeById>5__1; //Field offset: 0x30
		private HierarchyNodeChildren <nodes>5__2; //Field offset: 0x38
		private Enumerator <>s__3; //Field offset: 0x50
		private HierarchyNode <node>5__4; //Field offset: 0x70

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[CallerCount(Count = 2)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = "System.Linq.Expressions.Interpreter.TryCatchFinallyHandler", Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 6)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 1078
		}

		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <GetChildrenIds>d__25(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
		[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
		[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Hierarchy), Member = "EnumerateChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNodeChildren))]
		[Calls(Type = typeof(HierarchyNodeChildren), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
		[CallsUnknownMethods(Count = 4)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Linq.Expressions.Interpreter.TryCatchFinallyHandler", Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetChildrenIdsByIndex>d__41 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private int <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		private int index; //Field offset: 0x1C
		public int <>3__index; //Field offset: 0x20
		public BaseTreeViewController <>4__this; //Field offset: 0x28
		private HierarchyNodeChildren <nodes>5__1; //Field offset: 0x30
		private Enumerator <>s__2; //Field offset: 0x48
		private HierarchyNode <node>5__3; //Field offset: 0x68

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[CallerCount(Count = 2)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = "System.Linq.Expressions.Interpreter.TryCatchFinallyHandler", Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 6)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 1078
		}

		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <GetChildrenIdsByIndex>d__41(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
		[Calls(Type = typeof(Hierarchy), Member = "EnumerateChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNodeChildren))]
		[Calls(Type = typeof(HierarchyNodeChildren), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
		[CallsUnknownMethods(Count = 4)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Linq.Expressions.Interpreter.TryCatchFinallyHandler", Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly ProfilerMarker K_ExpandItemByIndex; //Field offset: 0x0
	 Hierarchy m_Hierarchy; //Field offset: 0x30
	 HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x38
	 HierarchyViewModel m_HierarchyViewModel; //Field offset: 0x40
	 Dictionary<Int32, HierarchyNode> m_IdToNodeDictionary; //Field offset: 0x48
	private IHierarchyProperty<Int32> m_TreeViewDataProperty; //Field offset: 0x50
	private bool m_HierarchyHasPendingChanged; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<TreeViewExpansionChangedArgs> itemExpandedChanged; //Field offset: 0x60

	internal event Action<TreeViewExpansionChangedArgs> itemExpandedChanged
	{
		[CalledBy(Type = typeof(BaseTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		internal add { } //Length: 160
		[CalledBy(Type = typeof(BaseTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		internal remove { } //Length: 160
	}

	protected BaseTreeView baseTreeView
	{
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "IsViewDataKeyEnabled", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 26)]
		 get { } //Length: 114
	}

	 Hierarchy hierarchy
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BaseTreeViewController), Member = "DisposeHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(HierarchyFlattened), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HierarchyViewModel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyFlattened), typeof(HierarchyNodeFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "GetOrCreatePropertyUnmanaged", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HierarchyPropertyStorageType)}, ReturnType = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1<T>")]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 352
	}

	public virtual IList itemsSource
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerCategory), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilerCategory)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static BaseTreeViewController() { }

	[CalledBy(Type = typeof(MultiColumnTreeViewController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewController), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "DisposeHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyFlattened), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyViewModel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyFlattened), typeof(HierarchyNodeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "GetOrCreatePropertyUnmanaged", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HierarchyPropertyStorageType)}, ReturnType = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected BaseTreeViewController() { }

	[CalledBy(Type = typeof(BaseTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	internal void add_itemExpandedChanged(Action<TreeViewExpansionChangedArgs> value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override bool CanChangeExpandedState(int id) { }

	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ClearIdToNodeDictionary() { }

	[CalledBy(Type = typeof(BaseTreeView), Member = "CollapseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void CollapseItem(int id, bool collapseAllChildren, bool refresh = true) { }

	[CalledBy(Type = typeof(BaseTreeView), Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void CollapseItemByIndex(int index, bool collapseAllChildren, bool refresh = true) { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(VisualElement), Member = "get_enableViewDataPersistence", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "RaiseItemExpandedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private void CollapseItemByNode(in HierarchyNode node, bool collapseAllChildren, bool refresh) { }

	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "<SetRootItems>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode)}, ReturnType = typeof(HierarchyNode))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "<SetRootItems>b__6_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode)}, ReturnType = typeof(HierarchyNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal HierarchyNode CreateNode(in HierarchyNode parent) { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "set_hierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HierarchyViewModel), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal void DisposeHierarchy() { }

	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "ExpandDropItem", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool Exists(int id) { }

	[CalledBy(Type = typeof(BaseTreeView), Member = "GetItemIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "ExpandItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ExpandItem(int id, bool expandAllChildren, bool refresh = true) { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true) { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(VisualElement), Member = "get_enableViewDataPersistence", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "RaiseItemExpandedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	private void ExpandItemByNode(in HierarchyNode node, bool expandAllChildren, bool refresh) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "DisposeHierarchy", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "IsViewDataKeyEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	protected BaseTreeView get_baseTreeView() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	 Hierarchy get_hierarchy() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual IList get_itemsSource() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[IteratorStateMachine(typeof(<GetAllItemIds>d__23))]
	public override IEnumerable<Int32> GetAllItemIds(IEnumerable<Int32> rootIds = null) { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "CompareId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "EnumerateChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNodeChildren))]
	[Calls(Type = typeof(HierarchyNodeChildren), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public int GetChildIndexForId(int id) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<GetChildrenIds>d__25))]
	public override IEnumerable<Int32> GetChildrenIds(int id) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<GetChildrenIdsByIndex>d__41))]
	public IEnumerable<Int32> GetChildrenIdsByIndex(int index) { }

	[CalledBy(Type = typeof(BaseTreeView), Member = "GetItemIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "ExpandDropItem", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(VisualElement), Member = "get_enableViewDataPersistence", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "EnumerateNodesWithAllFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNodeFlags)}, ReturnType = typeof(HierarchyViewNodesEnumerable))]
	[Calls(Type = typeof(HierarchyViewNodesEnumerable), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void GetExpandedItemIds(List<Int32> list) { }

	[CalledBy(Type = typeof(<GetChildrenIds>d__25), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "GetParentId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[CallsUnknownMethods(Count = 1)]
	internal HierarchyNode GetHierarchyNodeById(int id) { }

	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "GetItemForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "GetItemForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[CallsUnknownMethods(Count = 1)]
	internal HierarchyNode GetHierarchyNodeByIndex(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetIdForIndex(int index) { }

	[CalledBy(Type = typeof(MultiColumnController), Member = "CombinedComparisonById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	public int GetIndentationDepth(int id) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public int GetIndentationDepthByIndex(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetIndexForId(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override int GetParentId(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "GetChildrenCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool HasChildren(int id) { }

	[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasChildrenByIndex(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReusableTreeViewItem), Member = "UpdateIndentLayout", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "PostInitRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableTreeViewItem)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsChildOf(int childId, int id) { }

	[CalledBy(Type = typeof(BaseTreeView), Member = "IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsExpanded(int id) { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(Hierarchy), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsExpandedByIndex(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsIndexValid(int index) { }

	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(VisualElement), Member = "get_enableViewDataPersistence", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool IsViewDataKeyEnabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetChildIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public override void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "RaiseItemExpandedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_enableViewDataPersistence", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_userData", ReturnType = typeof(object))]
	[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	private void OnItemPointerUp(PointerUpEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_userData", ReturnType = typeof(object))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private void OnToggleValueChanged(ChangeEvent<Boolean> evt) { }

	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "Update", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal void OnViewDataReadyUpdateNodes() { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "InvokeMakeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeViewController), Member = "InvokeMakeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal void PostInitRegistration(ReusableTreeViewItem treeItem) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateHierarchy", ReturnType = typeof(void))]
	internal virtual void PreRefresh() { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void RaiseItemExpandedChanged(int id, bool isExpanded, bool isAppliedToAllChildren) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void RaiseItemParentChanged(int id, int newParentId) { }

	[CalledBy(Type = typeof(BaseTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	internal void remove_itemExpandedChanged(Action<TreeViewExpansionChangedArgs> value) { }

	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "DisposeHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyFlattened), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyViewModel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyFlattened), typeof(HierarchyNodeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "GetOrCreatePropertyUnmanaged", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HierarchyPropertyStorageType)}, ReturnType = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1<T>")]
	[CallsUnknownMethods(Count = 5)]
	 void set_hierarchy(Hierarchy value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void set_itemsSource(IList value) { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "PreRefresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeViewController), Member = "PreRefresh", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Hierarchy), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "Update", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateHierarchy() { }

	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "<SetRootItems>b__7_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HierarchyNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "<SetRootItems>b__6_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HierarchyNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, Unity.Hierarchy.HierarchyNode>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HierarchyNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateIdToNodeDictionary(int id, in HierarchyNode node, bool isAdd = true) { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "GetChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode[]))]
	[Calls(Type = typeof(HierarchyNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "SetSortIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "SortChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyFlattened), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "get_UpdateNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyViewModel), Member = "Update", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateSortOrder(in HierarchyNode newParent, in HierarchyNode insertedNode, int insertedIndex) { }

}

