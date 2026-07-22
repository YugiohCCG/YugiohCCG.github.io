namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class TwoPaneSplitViewResizer : PointerManipulator
{
	private Vector3 m_Start; //Field offset: 0x28
	protected bool m_Active; //Field offset: 0x34
	private TwoPaneSplitView m_SplitView; //Field offset: 0x38
	private int m_Direction; //Field offset: 0x40
	private float m_Delta; //Field offset: 0x44

	private VisualElement fixedPane
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 30
	}

	private float fixedPaneMargins
	{
		[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "ApplyDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 4)]
		private get { } //Length: 271
	}

	private float fixedPaneMinDimension
	{
		[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "ApplyDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(StyleFloat), Member = "get_value", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 155
	}

	private VisualElement flexedPane
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 30
	}

	private float flexedPaneMargin
	{
		[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "ApplyDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 4)]
		private get { } //Length: 271
	}

	private float flexedPaneMinDimension
	{
		[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "ApplyDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(StyleFloat), Member = "get_value", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 155
	}

	private TwoPaneSplitViewOrientation orientation
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 29
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerManipulator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public TwoPaneSplitViewResizer(TwoPaneSplitView splitView, int dir) { }

	[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(TwoPaneSplitViewResizer), Member = "get_fixedPaneMinDimension", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TwoPaneSplitViewResizer), Member = "get_flexedPaneMinDimension", ReturnType = typeof(float))]
	[Calls(Type = typeof(TwoPaneSplitViewResizer), Member = "get_flexedPaneMargin", ReturnType = typeof(float))]
	[Calls(Type = typeof(TwoPaneSplitViewResizer), Member = "get_fixedPaneMargins", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public void ApplyDelta(float delta) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private VisualElement get_fixedPane() { }

	[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "ApplyDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 4)]
	private float get_fixedPaneMargins() { }

	[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "ApplyDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(StyleFloat), Member = "get_value", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	private float get_fixedPaneMinDimension() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private VisualElement get_flexedPane() { }

	[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "ApplyDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 4)]
	private float get_flexedPaneMargin() { }

	[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "ApplyDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(StyleFloat), Member = "get_value", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	private float get_flexedPaneMinDimension() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private TwoPaneSplitViewOrientation get_orientation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStopManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void InterruptPointerMove(PointerMoveEvent e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopImmediatePropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void OnPointerDown(PointerDownEvent e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "HasPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStopManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(TwoPaneSplitViewResizer), Member = "ApplyDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected void OnPointerMove(PointerMoveEvent e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "HasPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStopManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void OnPointerUp(PointerUpEvent e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void RegisterCallbacksOnTarget() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void UnregisterCallbacksFromTarget() { }

}

