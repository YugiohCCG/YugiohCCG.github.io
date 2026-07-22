namespace UnityEngine.UI;

[AddComponentMenu("UI/Scrollbar", 36)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement
{
	[CompilerGenerated]
	private sealed class <ClickRepeat>d__59 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Scrollbar <>4__this; //Field offset: 0x20
		public Vector2 screenPosition; //Field offset: 0x28
		public Camera camera; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <ClickRepeat>d__59(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Coroutine)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private override bool MoveNext() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[CallerCount(Count = 31)]
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

	private enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	internal enum Direction
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3,
	}

	internal class ScrollEvent : UnityEvent<Single>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ScrollEvent() { }

	}

	[SerializeField]
	private RectTransform m_HandleRect; //Field offset: 0x100
	[SerializeField]
	private Direction m_Direction; //Field offset: 0x108
	[Range(0, 1)]
	[SerializeField]
	private float m_Value; //Field offset: 0x10C
	[Range(0, 1)]
	[SerializeField]
	private float m_Size; //Field offset: 0x110
	[Range(0, 11)]
	[SerializeField]
	private int m_NumberOfSteps; //Field offset: 0x114
	[SerializeField]
	[Space(6)]
	private ScrollEvent m_OnValueChanged; //Field offset: 0x118
	private RectTransform m_ContainerRect; //Field offset: 0x120
	private Vector2 m_Offset; //Field offset: 0x128
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x130
	private Coroutine m_PointerDownRepeat; //Field offset: 0x138
	private bool isPointerDownAndNotDragging; //Field offset: 0x140
	private bool m_DelayedUpdateVisuals; //Field offset: 0x141

	private Axis axis
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 21
	}

	public Direction direction
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
		 set { } //Length: 89
	}

	public RectTransform handleRect
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Scrollbar), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
		[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 101
	}

	public int numberOfSteps
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
		 set { } //Length: 111
	}

	public ScrollEvent onValueChanged
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	private bool reverseValue
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 23
	}

	public float size
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ON_TEXT_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateScrollbar", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
		 set { } //Length: 121
	}

	private float stepSize
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 46
	}

	public float value
	{
		[CalledBy(Type = typeof(Scrollbar), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 84
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ON_TEXT_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateScrollbar", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		 set { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected Scrollbar() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(IEnumerator))]
	[CallsUnknownMethods(Count = 1)]
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	[CalledBy(Type = typeof(Scrollbar), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[IteratorStateMachine(typeof(<ClickRepeat>d__59))]
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "FindSelectableOnDown", ReturnType = typeof(Selectable))]
	public virtual Selectable FindSelectableOnDown() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "FindSelectableOnLeft", ReturnType = typeof(Selectable))]
	public virtual Selectable FindSelectableOnLeft() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "FindSelectableOnRight", ReturnType = typeof(Selectable))]
	public virtual Selectable FindSelectableOnRight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "FindSelectableOnUp", ReturnType = typeof(Selectable))]
	public virtual Selectable FindSelectableOnUp() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private Axis get_axis() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Direction get_direction() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RectTransform get_handleRect() { }

	[CallerCount(Count = 0)]
	public int get_numberOfSteps() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ScrollEvent get_onValueChanged() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_reverseValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_size() { }

	[CallerCount(Count = 0)]
	private float get_stepSize() { }

	[CalledBy(Type = typeof(Scrollbar), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public float get_value() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void GraphicUpdateComplete() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void LayoutComplete() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool MayDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void OnDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scrollbar), Member = "get_value", ReturnType = typeof(float))]
	[Calls(Type = typeof(Selectable), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsInvalidInstructions]
	public virtual void OnMove(AxisEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(IEnumerator))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnPointerUp(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	protected virtual void OnRectTransformDimensionsChange() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Rebuild(CanvasUpdate executing) { }

	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "set_numberOfSteps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "DoUpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Single>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void Set(float input, bool sendCallback = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	public void set_direction(Direction value) { }

	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_handleRect(RectTransform value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	public void set_numberOfSteps(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_onValueChanged(ScrollEvent value) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ON_TEXT_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateScrollbar", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	public void set_size(float value) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ON_TEXT_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateScrollbar", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	public void set_value(float value) { }

	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutOnAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void SetValueWithoutNotify(float input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateVisuals", ReturnType = typeof(void))]
	protected override void Update() { }

	[CalledBy(Type = typeof(Scrollbar), Member = "set_handleRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateCachedReferences() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void UpdateDrag(PointerEventData eventData) { }

	[CalledBy(Type = typeof(<ClickRepeat>d__59), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateDrag(RectTransform containerRect, Vector2 position, Camera camera) { }

	[CalledBy(Type = typeof(Scrollbar), Member = "set_handleRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "set_numberOfSteps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "SetDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateVisuals() { }

}

