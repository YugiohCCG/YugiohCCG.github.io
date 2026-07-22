namespace UnityEngine.EventSystems;

public static class ExecuteEvents
{
	internal sealed class EventFunction : MulticastDelegate
	{

		[CallerCount(Count = 290)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public EventFunction`1(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(T1 handler, BaseEventData eventData) { }

	}

	private static readonly EventFunction<IPointerMoveHandler> s_PointerMoveHandler; //Field offset: 0x0
	private static readonly EventFunction<IPointerEnterHandler> s_PointerEnterHandler; //Field offset: 0x8
	private static readonly EventFunction<IPointerExitHandler> s_PointerExitHandler; //Field offset: 0x10
	private static readonly EventFunction<IPointerDownHandler> s_PointerDownHandler; //Field offset: 0x18
	private static readonly EventFunction<IPointerUpHandler> s_PointerUpHandler; //Field offset: 0x20
	private static readonly EventFunction<IPointerClickHandler> s_PointerClickHandler; //Field offset: 0x28
	private static readonly EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; //Field offset: 0x30
	private static readonly EventFunction<IBeginDragHandler> s_BeginDragHandler; //Field offset: 0x38
	private static readonly EventFunction<IDragHandler> s_DragHandler; //Field offset: 0x40
	private static readonly EventFunction<IEndDragHandler> s_EndDragHandler; //Field offset: 0x48
	private static readonly EventFunction<IDropHandler> s_DropHandler; //Field offset: 0x50
	private static readonly EventFunction<IScrollHandler> s_ScrollHandler; //Field offset: 0x58
	private static readonly EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; //Field offset: 0x60
	private static readonly EventFunction<ISelectHandler> s_SelectHandler; //Field offset: 0x68
	private static readonly EventFunction<IDeselectHandler> s_DeselectHandler; //Field offset: 0x70
	private static readonly EventFunction<IMoveHandler> s_MoveHandler; //Field offset: 0x78
	private static readonly EventFunction<ISubmitHandler> s_SubmitHandler; //Field offset: 0x80
	private static readonly EventFunction<ICancelHandler> s_CancelHandler; //Field offset: 0x88
	private static readonly List<Transform> s_InternalTransformList; //Field offset: 0x90

	public static EventFunction<IBeginDragHandler> beginDragHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<ICancelHandler> cancelHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 82
	}

	public static EventFunction<IDeselectHandler> deselectHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<IDragHandler> dragHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<IDropHandler> dropHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<IEndDragHandler> endDragHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<IMoveHandler> moveHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<IPointerClickHandler> pointerClickHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<IPointerDownHandler> pointerDownHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<IPointerEnterHandler> pointerEnterHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<IPointerExitHandler> pointerExitHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<IPointerMoveHandler> pointerMoveHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	public static EventFunction<IPointerUpHandler> pointerUpHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<IScrollHandler> scrollHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<ISelectHandler> selectHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static EventFunction<ISubmitHandler> submitHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 82
	}

	public static EventFunction<IUpdateSelectedHandler> updateSelectedHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 19)]
	private static ExecuteEvents() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Collections.Generic.IList`1<UnityEngine.EventSystems.IEventSystemHandler>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool CanHandleEvent(GameObject go) { }

	[CallerCount(Count = 69)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Collections.Generic.IList`1<UnityEngine.EventSystems.IEventSystemHandler>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool Execute(GameObject target, BaseEventData eventData, EventFunction<T> functor) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ValidateEventData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.PointerModel&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ButtonState&", typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.PointerModel&", typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleasePointerDrags", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMousePress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MouseButtonEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Collections.Generic.IList`1<UnityEngine.Transform>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static GameObject ExecuteHierarchy(GameObject root, BaseEventData eventData, EventFunction<T> callbackFunction) { }

	[CallerCount(Count = 0)]
	public static EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<ICancelHandler> get_cancelHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IDeselectHandler> get_deselectHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IDragHandler> get_dragHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IDropHandler> get_dropHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IEndDragHandler> get_endDragHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IMoveHandler> get_moveHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IPointerMoveHandler> get_pointerMoveHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IScrollHandler> get_scrollHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<ISelectHandler> get_selectHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<ISubmitHandler> get_submitHandler() { }

	[CallerCount(Count = 0)]
	public static EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	[CalledBy(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMousePress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MouseButtonEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.PointerModel&", typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ButtonState&", typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.PointerModel&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleasePointerDrags", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Collections.Generic.IList`1<UnityEngine.EventSystems.IEventSystemHandler>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static GameObject GetEventHandler(GameObject root) { }

	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "CanHandleEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	private static void GetEventList(GameObject go, IList<IEventSystemHandler> results) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private static bool ShouldSendToComponent(Component component) { }

	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDragHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMoveHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScrollHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDropHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEndDragHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInitializePotentialDragHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBeginDragHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerUpHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerDownHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerExitHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEnterHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerMoveHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecuteEvents), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerClickHandler), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public static T ValidateEventData(BaseEventData data) { }

}

