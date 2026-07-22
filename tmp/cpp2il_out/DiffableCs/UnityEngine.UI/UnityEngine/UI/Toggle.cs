namespace UnityEngine.UI;

[AddComponentMenu("UI/Toggle", 30)]
[RequireComponent(typeof(RectTransform))]
public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
{
	internal class ToggleEvent : UnityEvent<Boolean>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ToggleEvent() { }

	}

	internal enum ToggleTransition
	{
		None = 0,
		Fade = 1,
	}

	public ToggleTransition toggleTransition; //Field offset: 0x100
	public Graphic graphic; //Field offset: 0x108
	[SerializeField]
	private ToggleGroup m_Group; //Field offset: 0x110
	public ToggleEvent onValueChanged; //Field offset: 0x118
	[SerializeField]
	[Tooltip("Is the toggle currently on or off?")]
	private bool m_IsOn; //Field offset: 0x120

	public ToggleGroup group
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleGroup), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		 set { } //Length: 38
	}

	public bool isOn
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 119)]
		[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		 set { } //Length: 11
	}

	[CalledBy(Type = "UnityEngine.Rendering.UI.UIFoldout", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected Toggle() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ToggleGroup get_group() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isOn() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void GraphicUpdateComplete() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void InternalToggle() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void LayoutComplete() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ToggleGroup), Member = "EnsureValidState", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "GetColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected virtual void OnDidApplyAnimationProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleGroup), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleGroup), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override void OnSubmit(BaseEventData eventData) { }

	[CalledBy(Type = typeof(Toggle), Member = "set_group", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void PlayEffect(bool instant) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Rebuild(CanvasUpdate executing) { }

	[CalledBy(Type = typeof(ToggleGroup), Member = "SetAllTogglesOff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleGroup), Member = "NotifyToggleOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleGroup), Member = "EnsureValidState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "SetIsOnWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "InternalToggle", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ToggleGroup), Member = "AnyTogglesOn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ToggleGroup), Member = "NotifyToggleOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void Set(bool value, bool sendCallback = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleGroup), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void set_group(ToggleGroup value) { }

	[CallerCount(Count = 119)]
	[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	public void set_isOn(bool value) { }

	[CalledBy(Type = "Scenes.Lobby.LobbyScreen", Member = "OnHostButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.MultiPick", Member = "ValidateRules", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.MultiPick", Member = "SetCheckboxesForValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnFavoriteChanged>d__359", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "UpdateFavorite", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone", Member = "ToggleVisualLog", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DisplayCard+<OnFavoriteChanged>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DisplayCard", Member = "UpdateCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DisplayCard", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	public void SetIsOnWithoutNotify(bool value) { }

	[CalledBy(Type = typeof(Toggle), Member = "set_group", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Toggle), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ToggleGroup), Member = "NotifyToggleOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	[CalledBy(Type = "UnityEngine.Rendering.UI.UIFoldout", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	protected virtual void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[DeduplicatedMethod]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

