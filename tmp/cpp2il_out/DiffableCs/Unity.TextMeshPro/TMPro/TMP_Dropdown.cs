namespace TMPro;

[AddComponentMenu("UI/Dropdown - TextMeshPro", 35)]
[RequireComponent(typeof(RectTransform))]
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public Toggle nothingToggle; //Field offset: 0x10
		public Toggle everythingToggle; //Field offset: 0x18
		public TMP_Dropdown <>4__this; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass76_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <Show>b__0(bool x) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <Show>b__1(bool x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_1
	{
		public DropdownItem item; //Field offset: 0x10
		public TMP_Dropdown <>4__this; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass76_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <Show>b__2(bool x) { }

	}

	[CompilerGenerated]
	private sealed class <DelayedDestroyDropdownList>d__90 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float delay; //Field offset: 0x20
		public TMP_Dropdown <>4__this; //Field offset: 0x28

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
		public <DelayedDestroyDropdownList>d__90(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WaitForSecondsRealtime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_Dropdown), Member = "ImmediateDestroyDropdownList", ReturnType = typeof(void))]
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

	internal class DropdownEvent : UnityEvent<Int32>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DropdownEvent() { }

	}

	private class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
	{
		[SerializeField]
		private TMP_Text m_Text; //Field offset: 0x20
		[SerializeField]
		private Image m_Image; //Field offset: 0x28
		[SerializeField]
		private RectTransform m_RectTransform; //Field offset: 0x30
		[SerializeField]
		private Toggle m_Toggle; //Field offset: 0x38

		public Image image
		{
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public RectTransform rectTransform
		{
			[CallerCount(Count = 62)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public TMP_Text text
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 10)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public Toggle toggle
		{
			[CallerCount(Count = 38)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DropdownItem() { }

		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		public Image get_image() { }

		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		public RectTransform get_rectTransform() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public TMP_Text get_text() { }

		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		public Toggle get_toggle() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Dropdown), Member = "Hide", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void OnCancel(BaseEventData eventData) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void OnPointerEnter(PointerEventData eventData) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_image(Image value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_rectTransform(RectTransform value) { }

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_text(TMP_Text value) { }

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_toggle(Toggle value) { }

	}

	internal class OptionData
	{
		[SerializeField]
		private string m_Text; //Field offset: 0x10
		[SerializeField]
		private Sprite m_Image; //Field offset: 0x18
		[SerializeField]
		private Color m_Color; //Field offset: 0x20

		public Color color
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 11
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 8
		}

		public Sprite image
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public string text
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public OptionData() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public OptionData(string text) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public OptionData(Sprite image) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public OptionData(string text, Sprite image, Color color) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public Color get_color() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public Sprite get_image() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public string get_text() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_color(Color value) { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_image(Sprite value) { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_text(string value) { }

	}

	internal class OptionDataList
	{
		[SerializeField]
		private List<OptionData> m_Options; //Field offset: 0x10

		public List<OptionData> options
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public OptionDataList() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public List<OptionData> get_options() { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_options(List<OptionData> value) { }

	}

	private static readonly OptionData k_NothingOption; //Field offset: 0x0
	private static readonly OptionData k_EverythingOption; //Field offset: 0x8
	private static readonly OptionData k_MixedOption; //Field offset: 0x10
	private static OptionData s_NoOptionData; //Field offset: 0x18
	[SerializeField]
	private RectTransform m_Template; //Field offset: 0x100
	[SerializeField]
	private TMP_Text m_CaptionText; //Field offset: 0x108
	[SerializeField]
	private Image m_CaptionImage; //Field offset: 0x110
	[SerializeField]
	private Graphic m_Placeholder; //Field offset: 0x118
	[SerializeField]
	[Space]
	private TMP_Text m_ItemText; //Field offset: 0x120
	[SerializeField]
	private Image m_ItemImage; //Field offset: 0x128
	[SerializeField]
	[Space]
	private int m_Value; //Field offset: 0x130
	[SerializeField]
	private bool m_MultiSelect; //Field offset: 0x134
	[SerializeField]
	[Space]
	private OptionDataList m_Options; //Field offset: 0x138
	[SerializeField]
	[Space]
	private DropdownEvent m_OnValueChanged; //Field offset: 0x140
	[SerializeField]
	private float m_AlphaFadeSpeed; //Field offset: 0x148
	private GameObject m_Dropdown; //Field offset: 0x150
	private GameObject m_Blocker; //Field offset: 0x158
	private List<DropdownItem> m_Items; //Field offset: 0x160
	private TweenRunner<FloatTween> m_AlphaTweenRunner; //Field offset: 0x168
	private bool validTemplate; //Field offset: 0x170
	private Coroutine m_Coroutine; //Field offset: 0x178

	public float alphaFadeSpeed
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public Image captionImage
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 43
	}

	public TMP_Text captionText
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 43
	}

	public bool IsExpanded
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		 get { } //Length: 83
	}

	public Image itemImage
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 43
	}

	public TMP_Text itemText
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 43
	}

	public bool MultiSelect
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public DropdownEvent onValueChanged
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public List<OptionData> options
	{
		[CalledBy(Type = "HostSettings", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyGraphics>d__131", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "OnClickAddBot", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "OnApplyButton", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "ResetFilters", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "OnChangeBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.GeneralSelection", Member = "GetSelectionIndex", ReturnType = typeof(int))]
		[CalledBy(Type = "Scenes.Battle.ManualStatus", Member = "SetCounterTab", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.CyclicDropdown", Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 54
	}

	public Graphic placeholder
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 43
	}

	public RectTransform template
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 43
	}

	public int value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = "HostSettings", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "HostSettings", Member = "DefineBanlistDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "HostSettings", Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.GameSettings", typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "LoadFilters", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "ResetFilters", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.ManualStatus", Member = "SetCounterTab", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.CyclicDropdown", Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		 set { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private static TMP_Dropdown() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	protected TMP_Dropdown() { }

	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void AddOptions(List<OptionData> options) { }

	[CalledBy(Type = "HostSettings", Member = "ResetSelectors", ReturnType = typeof(void))]
	[CalledBy(Type = "HostSettings", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "HostSettings", Member = "DefineBanlistDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "InitializePuzzle", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "InitializeBot", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.GeneralSelection", Member = "OnFilterChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.GeneralSelection", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.ManualStatus", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(string), "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(int), "System.String[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void AddOptions(List<String> options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void AddOptions(List<Sprite> options) { }

	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Hide", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FloatTween), Member = "AddOnChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Events.UnityAction`1<System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenRunner`1), Member = "StartTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void AlphaFadeList(float duration, float start, float end) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CanvasGroup), Member = "get_alpha", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void AlphaFadeList(float duration, float alpha) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected virtual void Awake() { }

	[CalledBy(Type = "HostSettings", Member = "ResetSelectors", ReturnType = typeof(void))]
	[CalledBy(Type = "HostSettings", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "HostSettings", Member = "DefineBanlistDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "InitializePuzzle", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "InitializeBot", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.GeneralSelection", Member = "OnFilterChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.GeneralSelection", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.ManualStatus", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(string), "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(int), "System.String[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ClearOptions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Component))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(CanvasGroup), Member = "set_ignoreParentGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "set_layer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	protected override GameObject CreateBlocker(Canvas rootCanvas) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	protected override GameObject CreateDropdownList(GameObject template) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	protected override DropdownItem CreateItem(DropdownItem itemTemplate) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DelayedDestroyDropdownList>d__90))]
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	protected override void DestroyBlocker(GameObject blocker) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	protected override void DestroyDropdownList(GameObject dropdownList) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void DestroyItem(DropdownItem item) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static int EverythingValue(int count) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static int FirstActiveFlagIndex(int value) { }

	[CallerCount(Count = 0)]
	public float get_alphaFadeSpeed() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Image get_captionImage() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TMP_Text get_captionText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public bool get_IsExpanded() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Image get_itemImage() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TMP_Text get_itemText() { }

	[CallerCount(Count = 0)]
	public bool get_MultiSelect() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DropdownEvent get_onValueChanged() { }

	[CalledBy(Type = "HostSettings", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyGraphics>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "OnClickAddBot", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "OnApplyButton", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "ResetFilters", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "OnChangeBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.GeneralSelection", Member = "GetSelectionIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "Scenes.Battle.ManualStatus", Member = "SetCounterTab", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.CyclicDropdown", Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	public List<OptionData> get_options() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public Graphic get_placeholder() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RectTransform get_template() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_value() { }

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static T GetOrAddComponent(GameObject go) { }

	[CalledBy(Type = "Extensions.CyclicDropdown", Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DropdownItem), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CanvasGroup), Member = "get_alpha", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void Hide() { }

	[CalledBy(Type = typeof(<DelayedDestroyDropdownList>d__90), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void ImmediateDestroyDropdownList() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsEverythingValue(int count, int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "Hide", ReturnType = typeof(void))]
	public override void OnCancel(BaseEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "ImmediateDestroyDropdownList", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CalledBy(Type = typeof(<>c__DisplayClass76_0), Member = "<Show>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass76_0), Member = "<Show>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass76_1), Member = "<Show>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Toggle), Member = "SetIsOnWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "Hide", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void OnSelectItem(Toggle toggle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void OnSubmit(BaseEventData eventData) { }

	[CalledBy(Type = typeof(TMP_Dropdown), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Sprite>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+OptionData>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_itemImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_itemText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_options", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+OptionData>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_captionImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_captionText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_template", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "Extensions.General", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(int), "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(string), "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.ManualStatus", Member = "SetCounterTab", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_placeholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void RefreshShownValue() { }

	[CallerCount(Count = 0)]
	public void set_alphaFadeSpeed(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_captionImage(Image value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_captionText(TMP_Text value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_itemImage(Image value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_itemText(TMP_Text value) { }

	[CallerCount(Count = 0)]
	public void set_MultiSelect(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_onValueChanged(DropdownEvent value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_options(List<OptionData> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_placeholder(Graphic value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_template(RectTransform value) { }

	[CalledBy(Type = "HostSettings", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "HostSettings", Member = "DefineBanlistDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "HostSettings", Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.GameSettings", typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "LoadFilters", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "ResetFilters", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.ManualStatus", Member = "SetCounterTab", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.CyclicDropdown", Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public void set_value(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CanvasGroup), Member = "set_alpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetAlpha(float alpha) { }

	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Component))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void SetupTemplate() { }

	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Int32>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetValue(int value, bool sendCallback = true) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "<InitSocial>b__140_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "OnEqualizedValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_20", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_21", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_22", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_23", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_24", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_25", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_30", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_31", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "<Awake>b__327_32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(string), "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(int), "System.String[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[ContainsInvalidInstructions]
	public void SetValueWithoutNotify(int input) { }

	[CalledBy(Type = typeof(TMP_Dropdown), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "set_navigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Navigation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutOnAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OptionData), typeof(bool), typeof(DropdownItem), typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+DropdownItem>)}, ReturnType = typeof(DropdownItem))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Coroutine)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "ImmediateDestroyDropdownList", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_ListPool`1), Member = "Get", ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_isRootCanvas", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_ListPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetupTemplate", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Canvas), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 35)]
	[ContainsUnimplementedInstructions]
	public void Show() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Start() { }

}

