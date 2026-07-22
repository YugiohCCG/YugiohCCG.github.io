namespace UnityEngine.UI;

[AddComponentMenu("UI/Selectable", 35)]
[DisallowMultipleComponent]
[ExecuteAlways]
[SelectionBase]
public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	internal enum SelectionState
	{
		Normal = 0,
		Highlighted = 1,
		Pressed = 2,
		Selected = 3,
		Disabled = 4,
	}

	internal enum Transition
	{
		None = 0,
		ColorTint = 1,
		SpriteSwap = 2,
		Animation = 3,
	}

	protected static Selectable[] s_Selectables; //Field offset: 0x0
	protected static int s_SelectableCount; //Field offset: 0x8
	private bool m_EnableCalled; //Field offset: 0x20
	[FormerlySerializedAs("navigation")]
	[SerializeField]
	private Navigation m_Navigation; //Field offset: 0x28
	[FormerlySerializedAs("transition")]
	[SerializeField]
	private Transition m_Transition; //Field offset: 0x50
	[FormerlySerializedAs("colors")]
	[SerializeField]
	private ColorBlock m_Colors; //Field offset: 0x54
	[FormerlySerializedAs("spriteState")]
	[SerializeField]
	private SpriteState m_SpriteState; //Field offset: 0xB0
	[FormerlySerializedAs("animationTriggers")]
	[SerializeField]
	private AnimationTriggers m_AnimationTriggers; //Field offset: 0xD0
	[SerializeField]
	[Tooltip("Can the Selectable be interacted with?")]
	private bool m_Interactable; //Field offset: 0xD8
	[FormerlySerializedAs("highlightGraphic")]
	[FormerlySerializedAs("m_HighlightGraphic")]
	[SerializeField]
	private Graphic m_TargetGraphic; //Field offset: 0xE0
	private bool m_GroupsAllowInteraction; //Field offset: 0xE8
	protected int m_CurrentIndex; //Field offset: 0xEC
	[CompilerGenerated]
	private bool <isPointerInside>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private bool <isPointerDown>k__BackingField; //Field offset: 0xF1
	[CompilerGenerated]
	private bool <hasSelection>k__BackingField; //Field offset: 0xF2
	private readonly List<CanvasGroup> m_CanvasGroupCache; //Field offset: 0xF8

	public static int allSelectableCount
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", False)]
	public static List<Selectable> allSelectables
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		 get { } //Length: 255
	}

	public static Selectable[] allSelectablesArray
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		 get { } //Length: 143
	}

	public AnimationTriggers animationTriggers
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 91
	}

	public Animator animator
	{
		[CalledBy(Type = typeof(Selectable), Member = "TriggerAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		 get { } //Length: 57
	}

	public ColorBlock colors
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 62
		[CalledBy(Type = "UI.Dates.DatePickerDayButtonConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Button"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = "TMPro.TMP_InputField")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock&), typeof(ColorBlock)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 154
	}

	protected SelectionState currentSelectionState
	{
		[CalledBy(Type = "UnityEngine.UI.Button+<OnFinishSubmit>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Scrollbar), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 97
	}

	private bool hasSelection
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public Image image
	{
		[CalledBy(Type = "UI.Dates.DatePickerDayButtonConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Button"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerButtonConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Button"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "OnPlayerStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.RoomReadyButton", Member = "DefineReadyFrame", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.RoomReadyButton", Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.RoomReadyButton", Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scrollbar)}, ReturnType = typeof(void))]
		[CallerCount(Count = 38)]
		 get { } //Length: 117
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public bool interactable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 61)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 360
	}

	private bool isPointerDown
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	private bool isPointerInside
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public Navigation navigation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 29
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Navigation)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Navigation&), typeof(Navigation)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 118
	}

	public SpriteState spriteState
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 25
		[CalledBy(Type = "Manager.Helper", Member = "SetButtonSpriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteState)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteState&), typeof(SpriteState)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 110
	}

	public Graphic targetGraphic
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateToggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 91
	}

	public Transition transition
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = "Extensions.SliceButton", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 86
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Selectable() { }

	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(AnimationTriggers), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected Selectable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Awake() { }

	[CalledBy(Type = typeof(Selectable), Member = "InstantClearState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_overrideSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void DoSpriteSwap(Sprite newSprite) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "TriggerAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "StartColorTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected override void DoStateTransition(SelectionState state, bool instant) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsDeduplicatedMethods(Count = 3)]
	private void EvaluateAndTransitionToSelectionState() { }

	[CalledBy(Type = typeof(Selectable), Member = "FindSelectableOnLeft", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Selectable), Member = "FindSelectableOnRight", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Selectable), Member = "FindSelectableOnUp", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Selectable), Member = "FindSelectableOnDown", ReturnType = typeof(Selectable))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Selectable), Member = "GetPointOnRectEdge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public Selectable FindSelectable(Vector3 dir) { }

	[CalledBy(Type = typeof(Scrollbar), Member = "FindSelectableOnDown", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Slider), Member = "FindSelectableOnDown", ReturnType = typeof(Selectable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Selectable))]
	[CallsUnknownMethods(Count = 1)]
	public override Selectable FindSelectableOnDown() { }

	[CalledBy(Type = typeof(Scrollbar), Member = "FindSelectableOnLeft", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Slider), Member = "FindSelectableOnLeft", ReturnType = typeof(Selectable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Selectable))]
	[CallsUnknownMethods(Count = 1)]
	public override Selectable FindSelectableOnLeft() { }

	[CalledBy(Type = typeof(Scrollbar), Member = "FindSelectableOnRight", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Slider), Member = "FindSelectableOnRight", ReturnType = typeof(Selectable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Selectable))]
	[CallsUnknownMethods(Count = 1)]
	public override Selectable FindSelectableOnRight() { }

	[CalledBy(Type = typeof(Scrollbar), Member = "FindSelectableOnUp", ReturnType = typeof(Selectable))]
	[CalledBy(Type = typeof(Slider), Member = "FindSelectableOnUp", ReturnType = typeof(Selectable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Selectable))]
	[CallsUnknownMethods(Count = 1)]
	public override Selectable FindSelectableOnUp() { }

	[CallerCount(Count = 0)]
	public static int get_allSelectableCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	public static List<Selectable> get_allSelectables() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	public static Selectable[] get_allSelectablesArray() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AnimationTriggers get_animationTriggers() { }

	[CalledBy(Type = typeof(Selectable), Member = "TriggerAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	public Animator get_animator() { }

	[CallerCount(Count = 0)]
	public ColorBlock get_colors() { }

	[CalledBy(Type = "UnityEngine.UI.Button+<OnFinishSubmit>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected SelectionState get_currentSelectionState() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool get_hasSelection() { }

	[CalledBy(Type = "UI.Dates.DatePickerDayButtonConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Button"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerButtonConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Button"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "OnPlayerStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.RoomReadyButton", Member = "DefineReadyFrame", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.RoomReadyButton", Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.RoomReadyButton", Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scrollbar)}, ReturnType = typeof(void))]
	[CallerCount(Count = 38)]
	public Image get_image() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_interactable() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool get_isPointerDown() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool get_isPointerInside() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Navigation get_navigation() { }

	[CallerCount(Count = 0)]
	public SpriteState get_spriteState() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Graphic get_targetGraphic() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public Transition get_transition() { }

	[CalledBy(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Selectable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "TriggerAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void InstantClearState() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected bool IsHighlighted() { }

	[CallerCount(Count = 0)]
	public override bool IsInteractable() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected bool IsPressed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(BaseEventData), Member = "set_selectedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnApplicationFocus(bool hasFocus) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnCanvasGroupChanged() { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void OnDeselect(BaseEventData eventData) { }

	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected virtual void OnDidApplyAnimationProperties() { }

	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	protected virtual void OnDisable() { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	protected virtual void OnEnable() { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(BaseEventData), Member = "set_selectedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnMove(AxisEventData eventData) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerDown(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void OnPointerExit(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerUp(PointerEventData eventData) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = typeof(SelectionState))]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void OnSelect(BaseEventData eventData) { }

	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void OnSetProperty() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected virtual void OnTransformParentChanged() { }

	[CalledBy(Type = typeof(Selectable), Member = "OnCanvasGroupChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasGroup), Member = "get_interactable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasGroup), Member = "get_ignoreParentGroups", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private bool ParentGroupAllowsInteraction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Select() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_animationTriggers(AnimationTriggers value) { }

	[CalledBy(Type = "UI.Dates.DatePickerDayButtonConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Button"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = "TMPro.TMP_InputField")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock&), typeof(ColorBlock)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_colors(ColorBlock value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_hasSelection(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_image(Image value) { }

	[CallerCount(Count = 61)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_interactable(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_isPointerDown(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_isPointerInside(bool value) { }

	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Navigation)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Navigation&), typeof(Navigation)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_navigation(Navigation value) { }

	[CalledBy(Type = "Manager.Helper", Member = "SetButtonSpriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteState)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteState&), typeof(SpriteState)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_spriteState(SpriteState value) { }

	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateToggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_targetGraphic(Graphic value) { }

	[CalledBy(Type = "Extensions.SliceButton", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_transition(Transition value) { }

	[CalledBy(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void StartColorTween(Color targetColor, bool instant) { }

	[CalledBy(Type = typeof(Selectable), Member = "InstantClearState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectionState), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Animator), Member = "get_hasBoundPlayables", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "get_animator", ReturnType = typeof(Animator))]
	[Calls(Type = typeof(Animator), Member = "ResetTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Animator), Member = "SetTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void TriggerAnimation(string triggername) { }

}

