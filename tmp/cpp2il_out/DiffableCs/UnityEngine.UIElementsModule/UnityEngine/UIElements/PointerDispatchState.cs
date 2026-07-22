namespace UnityEngine.UIElements;

internal class PointerDispatchState
{
	private IEventHandler[] m_PendingPointerCapture; //Field offset: 0x10
	private IEventHandler[] m_PointerCapture; //Field offset: 0x18
	private Boolean[] m_ShouldSendCompatibilityMouseEvents; //Field offset: 0x20

	[CalledBy(Type = typeof(EventDispatcher), Member = "CreateDefault", ReturnType = typeof(EventDispatcher))]
	[CalledBy(Type = typeof(EventDispatcher), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public PointerDispatchState() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void ActivateCompatibilityMouseEvents(int pointerId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIUtility), Member = "get_hotControl", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "set_hotControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void CapturePointer(IEventHandler handler, int pointerId) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public IEventHandler GetCapturingElement(int pointerId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void PreventCompatibilityMouseEvents(int pointerId) { }

	[CalledBy(Type = typeof(PointerCaptureHelper), Member = "ProcessPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PointerCaptureEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(IEventHandler), typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	public void ProcessPointerCapture(int pointerId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void ReleasePointer(int pointerId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void ReleasePointer(IEventHandler handler, int pointerId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	internal void Reset() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }

}

