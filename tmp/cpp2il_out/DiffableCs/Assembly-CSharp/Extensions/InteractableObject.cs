namespace Extensions;

public class InteractableObject : AudibleObject, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler
{
	public const float TapSpeed = 0.5; //Field offset: 0x0
	private float HoldTime; //Field offset: 0x28
	protected bool IsHolding; //Field offset: 0x2C
	[CompilerGenerated]
	private bool <IsDragging>k__BackingField; //Field offset: 0x2D
	public Action OnHoldAction; //Field offset: 0x30
	public Action OnDoubleTapAction; //Field offset: 0x38
	public Action OnRightClickAction; //Field offset: 0x40
	public Action OnLeftClickAction; //Field offset: 0x48
	public Action OnHoverAction; //Field offset: 0x50
	public Action OnUnhoverAction; //Field offset: 0x58
	protected Action OnPointerDownAct; //Field offset: 0x60
	protected Action OnPointerUpAct; //Field offset: 0x68

	public bool IsDragging
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public InteractableObject() { }

	[CalledBy(Type = typeof(FieldSlot), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void FixedUpdate() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsDragging() { }

	[CallerCount(Count = 0)]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "OnTapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnClickButton() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected void OnDisable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected void OnEnable() { }

	[CallerCount(Count = 0)]
	public override void OnEndDrag(PointerEventData eventData) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "OnTapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkey), Member = "get_IsDoubleTouching", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnPointerDown(PointerEventData eventData) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "OnTapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnPointerExit(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerUp(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_IsDragging(bool value) { }

}

