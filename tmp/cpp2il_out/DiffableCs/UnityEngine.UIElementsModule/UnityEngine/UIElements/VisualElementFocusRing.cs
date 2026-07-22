namespace UnityEngine.UIElements;

public class VisualElementFocusRing : IFocusRing
{
	internal enum DefaultFocusOrder
	{
		ChildOrder = 0,
		PositionXY = 1,
		PositionYX = 2,
	}

	private class FocusRingRecord
	{
		public int m_AutoIndex; //Field offset: 0x10
		public Focusable m_Focusable; //Field offset: 0x18
		public bool m_IsSlot; //Field offset: 0x20
		public List<FocusRingRecord> m_ScopeNavigationOrder; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public FocusRingRecord() { }

	}

	private readonly VisualElement root; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DefaultFocusOrder <defaultFocusOrder>k__BackingField; //Field offset: 0x18
	private List<FocusRingRecord> m_FocusRing; //Field offset: 0x20

	public DefaultFocusOrder defaultFocusOrder
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	private FocusController focusController
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 39
	}

	[CalledBy(Type = typeof(NavigateFocusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public VisualElementFocusRing(VisualElement root, DefaultFocusOrder dfo = 0) { }

	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "DoUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_isCompositeRoot", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_areAncestorsAndSelfDisplayed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<FocusRingRecord> scopeList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "SortAndFlattenScopeLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void DoUpdate() { }

	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "FocusRingSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusRingRecord), typeof(FocusRingRecord)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Int32>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int FocusRingAutoIndexSort(FocusRingRecord a, FocusRingRecord b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Int32>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Int32>))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "FocusRingAutoIndexSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusRingRecord), typeof(FocusRingRecord)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int FocusRingSort(FocusRingRecord a, FocusRingRecord b) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DefaultFocusOrder get_defaultFocusOrder() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private FocusController get_focusController() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetFocusableInternalIndex(Focusable f) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(FocusController), Member = "GetFocusableParentForPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public override FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "SortAndFlattenScopeLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "get_delegatesFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetPreviousElementDepthFirst", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Focusable), Member = "get_excludeFromFocusRing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetRoot", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "GetNextElementDepthFirst", ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	public override Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "GetNextElementDepthFirst", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Focusable), Member = "get_excludeFromFocusRing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetRoot", ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static Focusable GetNextFocusableInTree(VisualElement currentFocusable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "GetPreviousElementDepthFirst", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Focusable), Member = "get_excludeFromFocusRing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetRoot", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_defaultFocusOrder(DefaultFocusOrder value) { }

	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "DoUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "SortAndFlattenScopeLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "SortAndFlattenScopeLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "get_excludeFromFocusRing", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void SortAndFlattenScopeLists(List<FocusRingRecord> rootScopeList) { }

}

