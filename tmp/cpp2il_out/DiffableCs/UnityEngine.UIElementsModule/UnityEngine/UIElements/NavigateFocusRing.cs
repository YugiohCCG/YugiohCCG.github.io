namespace UnityEngine.UIElements;

internal class NavigateFocusRing : IFocusRing
{
	internal class ChangeDirection : FocusChangeDirection
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ChangeDirection(int i) { }

	}

	private struct FocusableHierarchyTraversal
	{
		public VisualElement currentFocusable; //Field offset: 0x0
		public Rect validRect; //Field offset: 0x8
		public bool firstPass; //Field offset: 0x18
		public ChangeDirection direction; //Field offset: 0x20

		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(ChangeDirection)}, ReturnType = typeof(Focusable))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "ValidateHierarchyTraversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "StrictOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "TieBreaker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public VisualElement GetBestOverall(VisualElement candidate, VisualElement bestSoFar = null) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "StrictOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "TieBreaker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		private int Order(VisualElement a, VisualElement b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "StrictOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		private int StrictOrder(VisualElement a, VisualElement b) { }

		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "Order", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "StrictOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		private int StrictOrder(Rect ra, Rect rb) { }

		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "Order", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private int TieBreaker(Rect ra, Rect rb) { }

		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private bool ValidateElement(VisualElement v) { }

		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "get_worldBoundingBox", ReturnType = typeof(Rect))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private bool ValidateHierarchyTraversal(VisualElement v) { }

	}

	public static readonly ChangeDirection Left; //Field offset: 0x0
	public static readonly ChangeDirection Right; //Field offset: 0x8
	public static readonly ChangeDirection Up; //Field offset: 0x10
	public static readonly ChangeDirection Down; //Field offset: 0x18
	public static readonly FocusChangeDirection Next; //Field offset: 0x20
	public static readonly FocusChangeDirection Previous; //Field offset: 0x28
	private readonly VisualElement m_Root; //Field offset: 0x10
	private readonly VisualElementFocusRing m_Ring; //Field offset: 0x18

	private FocusController focusController
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 39
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private static NavigateFocusRing() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElementFocusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(DefaultFocusOrder)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public NavigateFocusRing(VisualElement root) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private FocusController get_focusController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(VisualElementFocusChangeTarget), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(VisualElementFocusChangeTarget))]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(FocusController), Member = "IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public override FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(ChangeDirection)}, ReturnType = typeof(Focusable))]
	[CallsUnknownMethods(Count = 2)]
	public override Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBoundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 5)]
	private Focusable GetNextFocusable2D(Focusable currentFocusable, ChangeDirection direction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsActive(VisualElement v) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsNavigable(Focusable focusable) { }

}

