namespace UnityEngine.Accessibility;

public class AccessibilityNode
{
	[DefaultMember("Item")]
	private class ObservableList
	{
		private readonly List<T> m_Items; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private Action listChanged; //Field offset: 0x0

		public event Action listChanged
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[CallsUnknownMethods(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 add { } //Length: 146
			[CalledBy(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[CallsUnknownMethods(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 remove { } //Length: 146
		}

		public override int Count
		{
			[CallerCount(Count = 36)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 26
		}

		public override T Item
		{
			[CalledBy(Type = typeof(AccessibilityNode), Member = "GetNodeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNodeData&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(AccessibilityNode), Member = "ChildrenChanged", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(AccessibilityNode), Member = "ActionsChanged", ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 42
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void add_listChanged(Action value) { }

		[CallerCount(Count = 36)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int get_Count() { }

		[CalledBy(Type = typeof(AccessibilityNode), Member = "GetNodeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNodeData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "ChildrenChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "ActionsChanged", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override T get_Item(int index) { }

		[CalledBy(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IEnumerator<T> GetEnumerator() { }

		[CalledBy(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void remove_listChanged(Action value) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <id>k__BackingField; //Field offset: 0x10
	private Func<Rect> m_FrameGetter; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<AccessibilityNode, Boolean> focusChanged; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<Boolean> selected; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action incremented; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action decremented; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<Boolean> dismissed; //Field offset: 0x40
	private string m_Label; //Field offset: 0x48
	private string m_Value; //Field offset: 0x50
	private string m_Hint; //Field offset: 0x58
	private bool m_IsActive; //Field offset: 0x60
	private AccessibilityRole m_Role; //Field offset: 0x62
	private bool m_AllowsDirectInteraction; //Field offset: 0x64
	private AccessibilityState m_State; //Field offset: 0x66
	private AccessibilityNode m_Parent; //Field offset: 0x68
	private ObservableList<AccessibilityNode> m_Children; //Field offset: 0x70
	private ObservableList<AccessibilityAction> m_Actions; //Field offset: 0x78
	private Rect m_Frame; //Field offset: 0x80
	private SystemLanguage m_Language; //Field offset: 0x90
	private AccessibilityHierarchy m_Hierarchy; //Field offset: 0x98

	public bool allowsDirectInteraction
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal IList<AccessibilityNode> childList
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public Rect frame
	{
		[CalledBy(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "GetNodeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNodeData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 518
	}

	public Func<Rect> frameGetter
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string hint
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int id
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool isActive
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string label
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	internal SystemLanguage language
	{
		[CallerCount(Count = 33)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	public AccessibilityNode parent
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public AccessibilityRole role
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
	}

	public AccessibilityState state
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
	}

	public string value
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[Calls(Type = typeof(ObservableList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void ActionsChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void CalculateFrame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[Calls(Type = typeof(ObservableList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void ChildrenChanged() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool Dismissed() { }

	[CalledBy(Type = typeof(AccessibilityHierarchy), Member = "FreeNative", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObservableList`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObservableList`1), Member = "remove_listChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	internal void FreeNative(bool freeChildren) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_allowsDirectInteraction() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	internal IList<AccessibilityNode> get_childList() { }

	[CalledBy(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "GetNodeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNodeData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public Rect get_frame() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Func<Rect> get_frameGetter() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_hint() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_id() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isActive() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_label() { }

	[CallerCount(Count = 33)]
	[DeduplicatedMethod]
	internal SystemLanguage get_language() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public AccessibilityNode get_parent() { }

	[CallerCount(Count = 0)]
	public AccessibilityRole get_role() { }

	[CallerCount(Count = 0)]
	public AccessibilityState get_state() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_value() { }

	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_GetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNodeData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AccessibilityNode), Member = "get_frame", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ObservableList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal void GetNodeData(ref AccessibilityNodeData nodeData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void InvokeDecremented() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void InvokeFocusChanged(bool isNodeFocused) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void InvokeIncremented() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool InvokeSelected() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[ContainsUnimplementedInstructions]
	private bool IsInActiveHierarchy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AccessibilityManager), Member = "QueueNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotificationContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void NotifyFocusChanged(bool isNodeFocused) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void SetFrame(Rect frame) { }

}

