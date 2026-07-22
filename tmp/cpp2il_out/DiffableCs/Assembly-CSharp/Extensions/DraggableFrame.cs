namespace Extensions;

public class DraggableFrame : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
	public static float TapSpeedTimer; //Field offset: 0x0
	public GameObject DragFrame; //Field offset: 0x20
	public bool AllowDrag; //Field offset: 0x28
	protected Vector3 StartingObjectPosition; //Field offset: 0x2C
	protected Vector3 DragOffset; //Field offset: 0x38
	private bool IsHovering; //Field offset: 0x44
	private bool IsHolding; //Field offset: 0x45
	[CompilerGenerated]
	private bool <IsDragging>k__BackingField; //Field offset: 0x46
	public bool IsInWorld; //Field offset: 0x47
	protected bool SpecialHolding; //Field offset: 0x48
	public Action OnHold; //Field offset: 0x50
	private float HoldTime; //Field offset: 0x58
	public Action OnFinishMoving; //Field offset: 0x60
	public Action<PointerEventData> OnClick; //Field offset: 0x68
	public string SavePositionAs; //Field offset: 0x70
	public bool SaveAsLocal; //Field offset: 0x78
	[SerializeField]
	private bool LoadLastPosition; //Field offset: 0x79
	public Action<PointerEventData> OnRightClickBeginDrag; //Field offset: 0x80
	public Action<PointerEventData, Vector3> OnRightClickDrag; //Field offset: 0x88
	public Action<PointerEventData> OnRightClickEndDrag; //Field offset: 0x90

	public private bool IsDragging
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private bool KeepPositionSaved
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		private get { } //Length: 22
	}

	private Vector3 LoadPos
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 110
	}

	[CallerCount(Count = 0)]
	private static DraggableFrame() { }

	[CalledBy(Type = typeof(PhaseSelect), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelLogger), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectCardPosition), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RaceSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualStatus), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GeneralSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardListDisplay), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AttributeSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextBox), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OptionBox), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LifePoints), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InfoBox), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DraggableFrame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	private void Awake() { }

	[CalledBy(Type = typeof(DraggableFrame), Member = "LoadPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "LoadPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "LoadPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(DraggableFrame), Member = "IsOutOfScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOLocalMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetEase", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Ease)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 4)]
	private bool CheckForRearrange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void FixedUpdate() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public bool get_IsDragging() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	private bool get_KeepPositionSaved() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	private Vector3 get_LoadPos() { }

	[CalledBy(Type = typeof(DraggableFrame), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "CheckForRearrange", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private bool IsOutOfScreen(Vector2 pos) { }

	[CalledBy(Type = typeof(DuelZone), Member = "SetupDuelZone", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DraggableFrame), Member = "CheckForRearrange", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void LoadPosition() { }

	[CalledBy(Type = typeof(DuelZone), Member = "SetUpOptimizedView", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DraggableFrame), Member = "CheckForRearrange", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DraggableFrame), Member = "StorePosition", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void LoadPosition(Vector2 pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DraggableFrame), Member = "CheckForRearrange", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected void LoadPosition(Vector3 def) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Hotkey), Member = "get_IsDoubleTouching", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "set_Pointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DraggableFrame), Member = "ResetCursor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DraggableFrame), Member = "ResetCursor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DraggableFrame), Member = "IsOutOfScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Hotkey), Member = "get_IsDoubleTouching", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DraggableFrame), Member = "LoadPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DraggableFrame), Member = "ResetCursor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DraggableFrame), Member = "CheckForRearrange", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "get_IsDoubleTouching", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DraggableFrame), Member = "StorePosition", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnEndDrag(PointerEventData eventData) { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public override void OnPointerDown(PointerEventData eventData) { }

	[CalledBy(Type = typeof(Template), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[CalledBy(Type = typeof(Template), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public override void OnPointerExit(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public override void OnPointerUp(PointerEventData eventData) { }

	[CalledBy(Type = typeof(DraggableFrame), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Helper), Member = "set_Pointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ResetCursor() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_IsDragging(bool value) { }

	[CalledBy(Type = typeof(DraggableFrame), Member = "LoadPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void StorePosition() { }

}

