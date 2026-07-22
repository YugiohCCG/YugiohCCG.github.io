namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Event Trigger")]
public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
{
	internal class Entry
	{
		public EventTriggerType eventID; //Field offset: 0x10
		public TriggerEvent callback; //Field offset: 0x18

		[CalledBy(Type = "Extensions.General", Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTrigger), typeof(EventTriggerType), "System.Action`1<PointerEventData>"}, ReturnType = typeof(EventTrigger))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public Entry() { }

	}

	internal class TriggerEvent : UnityEvent<BaseEventData>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public TriggerEvent() { }

	}

	[FormerlySerializedAs("delegates")]
	[SerializeField]
	private List<Entry> m_Delegates; //Field offset: 0x20

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", True)]
	public List<Entry> delegates
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventTrigger), Member = "get_triggers", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.EventTrigger+Entry>))]
		 get { } //Length: 7
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public List<Entry> triggers
	{
		[CalledBy(Type = "Extensions.General", Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTrigger), typeof(EventTriggerType), "System.Action`1<PointerEventData>"}, ReturnType = typeof(EventTrigger))]
		[CalledBy(Type = "Extensions.General", Member = "ClearTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventTrigger), Member = "get_delegates", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.EventTrigger+Entry>))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 122
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected EventTrigger() { }

	[CalledBy(Type = typeof(EventTrigger), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnInitializePotentialDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "get_triggers", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.EventTrigger+Entry>))]
	public List<Entry> get_delegates() { }

	[CalledBy(Type = "Extensions.General", Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTrigger), typeof(EventTriggerType), "System.Action`1<PointerEventData>"}, ReturnType = typeof(EventTrigger))]
	[CalledBy(Type = "Extensions.General", Member = "ClearTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventTrigger), Member = "get_delegates", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.EventTrigger+Entry>))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public List<Entry> get_triggers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnCancel(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnDeselect(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnDrop(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnEndDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnMove(AxisEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnPointerDown(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnPointerExit(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnPointerUp(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnScroll(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnSelect(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnSubmit(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(BaseEventData)}, ReturnType = typeof(void))]
	public override void OnUpdateSelected(BaseEventData eventData) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_delegates(List<Entry> value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_triggers(List<Entry> value) { }

}

