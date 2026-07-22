namespace UnityEngine.UI;

[AddComponentMenu("UI/Slider", 34)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
{
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

	internal class SliderEvent : UnityEvent<Single>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public SliderEvent() { }

	}

	[SerializeField]
	private RectTransform m_FillRect; //Field offset: 0x100
	[SerializeField]
	private RectTransform m_HandleRect; //Field offset: 0x108
	[SerializeField]
	[Space]
	private Direction m_Direction; //Field offset: 0x110
	[SerializeField]
	private float m_MinValue; //Field offset: 0x114
	[SerializeField]
	private float m_MaxValue; //Field offset: 0x118
	[SerializeField]
	private bool m_WholeNumbers; //Field offset: 0x11C
	[SerializeField]
	protected float m_Value; //Field offset: 0x120
	[SerializeField]
	[Space]
	private SliderEvent m_OnValueChanged; //Field offset: 0x128
	private Image m_FillImage; //Field offset: 0x130
	private Transform m_FillTransform; //Field offset: 0x138
	private RectTransform m_FillContainerRect; //Field offset: 0x140
	private Transform m_HandleTransform; //Field offset: 0x148
	private RectTransform m_HandleContainerRect; //Field offset: 0x150
	private Vector2 m_Offset; //Field offset: 0x158
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x160
	private bool m_DelayedUpdateVisuals; //Field offset: 0x161

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
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		 set { } //Length: 89
	}

	public RectTransform fillRect
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
		[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 101
	}

	public RectTransform handleRect
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
		[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 101
	}

	public float maxValue
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "InitGameplay", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.ValueSlider", Member = "DefineMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 122
	}

	public float minValue
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "InitGameplay", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "InitCard", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.ValueSlider", Member = "DefineMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 122
	}

	public float normalizedValue
	{
		[CalledBy(Type = typeof(Slider), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 169
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 77
	}

	public SliderEvent onValueChanged
	{
		[CallerCount(Count = 0)]
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

	private float stepSize
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 43
	}

	public override float value
	{
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		 get { } //Length: 22
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 20
	}

	public bool wholeNumbers
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 122
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected Slider() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private float ClampValue(float input) { }

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
	public RectTransform get_fillRect() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RectTransform get_handleRect() { }

	[CallerCount(Count = 0)]
	public float get_maxValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_minValue() { }

	[CalledBy(Type = typeof(Slider), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_normalizedValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SliderEvent get_onValueChanged() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_reverseValue() { }

	[CallerCount(Count = 0)]
	private float get_stepSize() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public override float get_value() { }

	[CallerCount(Count = 0)]
	public bool get_wholeNumbers() { }

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
	[Calls(Type = typeof(Slider), Member = "get_normalizedValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Single>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected virtual void OnDidApplyAnimationProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Slider), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Camera)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void OnMove(AxisEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Camera)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	protected virtual void OnRectTransformDimensionsChange() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Rebuild(CanvasUpdate executing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Single>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected override void Set(float input, bool sendCallback = true) { }

	[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	public void set_direction(Direction value) { }

	[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_fillRect(RectTransform value) { }

	[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_handleRect(RectTransform value) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "InitGameplay", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ValueSlider", Member = "DefineMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_maxValue(float value) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "InitGameplay", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "InitCard", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ValueSlider", Member = "DefineMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_minValue(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_normalizedValue(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_onValueChanged(SliderEvent value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void set_value(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_wholeNumbers(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutOnAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void SetValueWithoutNotify(float input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void Update() { }

	[CalledBy(Type = typeof(Slider), Member = "set_fillRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_handleRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateCachedReferences() { }

	[CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	[CalledBy(Type = typeof(Slider), Member = "set_fillRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "SetDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_maxValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_minValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_handleRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_wholeNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Slider), Member = "get_normalizedValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(Image), Member = "set_fillAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateVisuals() { }

}

