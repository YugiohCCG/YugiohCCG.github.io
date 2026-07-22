namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class UIRLayoutUpdater : BaseVisualTreeUpdater
{
	private static readonly string s_Description; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	private static readonly ProfilerMarker k_ComputeLayoutMarker; //Field offset: 0x10
	private static readonly ProfilerMarker k_UpdateSubTreeMarker; //Field offset: 0x18
	private static readonly ProfilerMarker k_DispatchChangeEventsMarker; //Field offset: 0x20
	private List<ValueTuple`3<Rect, Rect, VisualElement>> changeEventsList; //Field offset: 0x28
	private List<VisualElement> missedHierarchyChangeEventsList; //Field offset: 0x30

	public virtual ProfilerMarker profilerMarker
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 1)]
	private static UIRLayoutUpdater() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public UIRLayoutUpdater() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, System.Object>>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GeometryChangedEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(GeometryChangedEvent))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void DispatchChangeEvents(List<ValueTuple`3<Rect, Rect, VisualElement>> changeEvents, int currentLayoutPass) { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(GeometryChangedEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(GeometryChangedEvent))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void DispatchMissedHierarchyChangeEvents(List<VisualElement> missedHierarchyChangeEvents, int currentLayoutPass) { }

	[CallerCount(Count = 0)]
	public virtual ProfilerMarker get_profilerMarker() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(LayoutNode), Member = "get_IsMeasureDefined", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkDirty", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVisualTreeUpdater), Member = "get_visualTree", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(LayoutNode), Member = "get_IsDirty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "CalculateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRLayoutUpdater), Member = "DispatchChangeEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRLayoutUpdater), Member = "DispatchMissedHierarchyChangeEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "ReevaluateFocus", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Update() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "set_disableRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_areAncestorsAndSelfDisplayed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_areAncestorsAndSelfDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "HasSelfEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static bool UpdateHierarchyDisplayed(VisualElement ve, List<ValueTuple`3<Rect, Rect, VisualElement>> changeEvents, bool inheritedDisplayed = true) { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(LayoutNode), Member = "MarkLayoutSeen", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_boundingBoxDirtiedSinceLastLayoutPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBoxDirtiedSinceLastLayoutPass", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_receivesHierarchyGeometryChangedEvents", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "HasSelfEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayoutNode), Member = "get_HasNewLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_scale", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutPaddingBottom", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutPaddingRight", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutPaddingLeft", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutY", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutX", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(VisualElement), Member = "get_areAncestorsAndSelfDisplayed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private void UpdateSubTree(VisualElement ve, List<ValueTuple`3<Rect, Rect, VisualElement>> changeEvents) { }

}

