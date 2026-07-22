namespace UI.Dates;

[ExecuteInEditMode]
public class DatePicker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SerializableDate, Boolean> <>9__82_0; //Field offset: 0x8
		public static Func<SerializableDate, Boolean> <>9__82_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializableDate), Member = "get_HasValue", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <UpdateInputFieldText>b__82_0(SerializableDate s) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializableDate), Member = "get_HasValue", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <UpdateInputFieldText>b__82_1(SerializableDate s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public DatePicker <>4__this; //Field offset: 0x10
		public List<String> dayNames; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass70_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TableLayout), Member = "get_Rows", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableRow>))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TableRow), Member = "get_Cells", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableCell>))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 8)]
		internal void <_UpdateDisplay>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <_UpdateDisplay>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_1
	{
		public DateTime day; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass70_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializableDate), Member = "get_HasValue", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		internal bool <_UpdateDisplay>b__2(SerializableDate pd) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass81_0
	{
		public DateTime date; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass81_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		internal bool <DayButtonClicked>b__0(SerializableDate d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass96_0
	{
		public DatePickerDayButtonType type; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass96_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetDayButtons>b__0(DatePicker_DayButton d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass98_0
	{
		public string dateString; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass98_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <GetDayButton>b__0(DatePicker_DayButton d) { }

	}

	[SerializeField]
	private DateSelectionMode m_DateSelectionMode; //Field offset: 0x20
	[SerializeField]
	private SerializableDate m_SelectedDate; //Field offset: 0x28
	[SerializeField]
	private List<SerializableDate> m_SelectedDates; //Field offset: 0x30
	[SerializeField]
	private SerializableDate m_VisibleDate; //Field offset: 0x38
	[Tooltip("Defines how 'VisibleDate' is calculated, if at all. Only used if Selected Date has no value.")]
	public VisibleDateDefaultBehaviour VisibleDateDefaultBehaviour; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsSharedCalendar>k__BackingField; //Field offset: 0x44
	public DatePickerConfig Config; //Field offset: 0x48
	[Header("References")]
	public RectTransform Ref_DatePickerTransform; //Field offset: 0xB0
	public DatePicker_Header Ref_Header; //Field offset: 0xB8
	public TableLayout Ref_DayTable; //Field offset: 0xC0
	public DatePicker_Animator Ref_DayTableAnimator; //Field offset: 0xC8
	public TableCell Ref_DayTableContainer; //Field offset: 0xD0
	public DatePicker_DayHeader Ref_Template_DayName; //Field offset: 0xD8
	public DatePicker_DayButton Ref_Template_Day_CurrentMonth; //Field offset: 0xE0
	public DatePicker_DayButton Ref_Template_Day_OtherMonths; //Field offset: 0xE8
	public DatePicker_DayButton Ref_Template_Day_Today; //Field offset: 0xF0
	public DatePicker_DayButton Ref_Template_Day_SelectedDay; //Field offset: 0xF8
	public Image Ref_Border; //Field offset: 0x100
	public DatePicker_ContentLayout Ref_ContentLayout; //Field offset: 0x108
	public Image Ref_ScreenOverlay; //Field offset: 0x110
	public DatePicker_Animator Ref_ScreenOverlayAnimator; //Field offset: 0x118
	public DatePicker_Animator Ref_Animator; //Field offset: 0x120
	private GameObject Panel_BlockRaycasts; //Field offset: 0x128
	[FormerlySerializedAs("Ref_InputField")]
	[HideInInspector]
	[SerializeField]
	private InputField Ref_OldInputField; //Field offset: 0x130
	[SerializeField]
	private TMP_InputField m_Ref_InputField; //Field offset: 0x138
	public TableLayout Ref_InputFieldContainer; //Field offset: 0x140
	public TableCell Ref_InputFieldToggleButtonCell; //Field offset: 0x148
	public DatePicker_DateRange Ref_DatePicker_DateRange; //Field offset: 0x150
	[SerializeField]
	private DatePicker_DayButton_Pool _buttonPool; //Field offset: 0x158
	public RectTransform Ref_Viewport; //Field offset: 0x160
	private bool m_initialized; //Field offset: 0x168
	private bool m_updateScheduled; //Field offset: 0x169
	public bool IsMax; //Field offset: 0x16A

	private DatePicker_DayButton_Pool buttonPool
	{
		[CalledBy(Type = typeof(DatePicker), Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "InvalidateAllDayButtonTemplates", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "InvalidateDayButtonTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 267
	}

	public DateSelectionMode DateSelectionMode
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(DatePicker_InputField), Member = "ShowCalendar", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ExampleController), Member = "ToggleAllowMultipleDateSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		 set { } //Length: 75
	}

	public bool IsSharedCalendar
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool IsVisible
	{
		[CalledBy(Type = typeof(DatePicker_DateRange), Member = "InputFieldClicked", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_DateRange), Member = "ToggleDisplay", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 47
	}

	public TMP_InputField Ref_InputField
	{
		[CalledBy(Type = typeof(HostSettings), Member = "OnCreateRoomButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HostSettings), Member = "SaveHostRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32&)}, ReturnType = typeof(GameSettings))]
		[CalledBy(Type = typeof(DatePicker), Member = "OnTextFieldValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "UpdateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "UpdateInputFieldText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "LoadFilters", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "SaveFilters", ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DatePicker_TextMeshProUtilities), Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 185
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public SerializableDate SelectedDate
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DatePicker), Member = "OnTextFieldValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "DayButtonClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_DateRange), Member = "set_FromDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_DateRange), Member = "set_ToDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_DateRange), Member = "DateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_InputField), Member = "ShowCalendar", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "ResetFilters", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate&), typeof(SerializableDate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DatePicker), Member = "UpdateInputFieldText", ReturnType = typeof(void))]
		[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 182
	}

	public List<SerializableDate> SelectedDates
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DatePicker_InputField), Member = "ShowCalendar", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
		 set { } //Length: 76
	}

	public SerializableDate VisibleDate
	{
		[CalledBy(Type = typeof(DatePicker), Member = "ShowPreviousMonth", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "ShowNextMonth", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "ShowPreviousYear", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "ShowNextYear", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "UpdateHeader", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "GetDayTypeForDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DatePickerDayButtonType))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(SerializableDate), Member = "get_HasValue", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "get_Today", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(SerializableDate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 192
		[CalledBy(Type = typeof(DatePicker_Instantiation), Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(Transform)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate&), typeof(SerializableDate)}, ReturnType = typeof(void))]
		 set { } //Length: 76
	}

	[CalledBy(Type = typeof(DatePicker), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePicker_DayHeader), Member = "get_HeaderText", ReturnType = typeof(TextMeshProUGUI))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "get_VisibleDate", ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DatePickerUtilities), Member = "GetDateRangeForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(System.Collections.Generic.List`1<System.DateTime>))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_DayOfWeek", ReturnType = typeof(DayOfWeek))]
	[Calls(Type = typeof(DatePicker), Member = "GetDayTypeForDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DatePickerDayButtonType))]
	[Calls(Type = typeof(DatePicker_DayButton_Pool), Member = "GetButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(DatePicker_DayButton))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_Button), Member = "get_Cell", ReturnType = typeof(TableCell))]
	[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_Button), Member = "get_Text", ReturnType = typeof(TextMeshProUGUI))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(List`1<DateTime>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePickerTimer), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Action), typeof(MonoBehaviour), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "UpdateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(TableRow), Member = "AddCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableCell)}, ReturnType = typeof(TableCell))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_ContentLayout), Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "UpdateHeader", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePickerWeekDaysConfig), Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_DayHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "UpdateDaySection", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "get_buttonPool", ReturnType = typeof(DatePicker_DayButton_Pool))]
	[Calls(Type = typeof(DatePicker_DayButton_Pool), Member = "FreeAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(TableLayout), Member = "get_Rows", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableRow>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Single>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePickerDateRangeConfig), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FirstDayOfWeek", ReturnType = typeof(DayOfWeek))]
	[Calls(Type = typeof(DatePickerUtilities), Member = "Shift", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = "T[]")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(TableLayout), Member = "AddRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TableRow))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TableRow), Member = "get_Cells", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableCell>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedDayNames", ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 52)]
	private void _UpdateDisplay() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public DatePicker() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker_Animator), Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(AnimationType), typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <MonthChangedUpdateDisplay>b__67_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <SetPositionAdjacentToInputFieldContainer>b__92_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Show>b__87_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "get_buttonPool", ReturnType = typeof(DatePicker_DayButton_Pool))]
	[Calls(Type = typeof(DatePicker_DayButton_Pool), Member = "InvalidateAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(TableLayout), Member = "get_Rows", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableRow>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_DayButton_Pool), Member = "AddExistingButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_DayButton)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializableDate), Member = "get_HasValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Today", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate&), typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ClearWeekDayHeaders() { }

	[CalledBy(Type = typeof(DatePicker_DayButton), Member = "Clicked", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UI.Dates.SerializableDate>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_DateRange), Member = "DateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.DateTime>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "UpdateInputFieldText", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void DayButtonClicked(DateTime date) { }

	[CalledBy(Type = typeof(DatePicker_DayButton), Member = "MouseOver", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.DateTime>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	public void DayButtonMouseOver(DateTime date) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Transform), Member = "SetAsLastSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public void Disable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Enable() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static T FindParentOfType(GameObject childObject) { }

	[CalledBy(Type = typeof(DatePicker), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "InvalidateAllDayButtonTemplates", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "InvalidateDayButtonTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	private DatePicker_DayButton_Pool get_buttonPool() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public DateSelectionMode get_DateSelectionMode() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsSharedCalendar() { }

	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "InputFieldClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "ToggleDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsVisible() { }

	[CalledBy(Type = typeof(HostSettings), Member = "OnCreateRoomButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "SaveHostRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32&)}, ReturnType = typeof(GameSettings))]
	[CalledBy(Type = typeof(DatePicker), Member = "OnTextFieldValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateInputFieldText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "LoadFilters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "SaveFilters", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_TextMeshProUtilities), Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
	[CallsUnknownMethods(Count = 1)]
	public TMP_InputField get_Ref_InputField() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public SerializableDate get_SelectedDate() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public List<SerializableDate> get_SelectedDates() { }

	[CalledBy(Type = typeof(DatePicker), Member = "ShowPreviousMonth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ShowNextMonth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ShowPreviousYear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ShowNextYear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateHeader", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "GetDayTypeForDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DatePickerDayButtonType))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(SerializableDate), Member = "get_HasValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Today", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(SerializableDate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public SerializableDate get_VisibleDate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public DatePicker_DayButton GetDayButton(DateTime date) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public List<DatePicker_DayButton> GetDayButtons(DatePickerDayButtonType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	private List<DatePicker_DayButton> GetDayButtons() { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializableDate), Member = "get_HasValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UI.Dates.SerializableDate>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Today", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DatePicker), Member = "get_VisibleDate", ReturnType = typeof(SerializableDate))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private DatePickerDayButtonType GetDayTypeForDate(DateTime date) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	public string GetSerializedConfiguration() { }

	[CalledBy(Type = typeof(DatePicker), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "HideCalendar", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "ToggleDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "InputFieldClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "ModalOverlayClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "<DateSelected>b__17_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "ToggleDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "InputFieldClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ToggleDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "InputFieldClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ModalOverlayClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "Hide", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(DatePicker), Member = "HideInstantly", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Hide() { }

	[CalledBy(Type = typeof(HostSettings), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "EnableButtonsForUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "HideCalendars", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "<Start>b__43_1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "<Start>b__43_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "HideCalendars", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void HideInstantly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void HideScreenOverlay_Complete() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void InputFieldClicked() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "get_buttonPool", ReturnType = typeof(DatePicker_DayButton_Pool))]
	[Calls(Type = typeof(DatePicker_DayButton_Pool), Member = "InvalidateAll", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void InvalidateAllDayButtonTemplates() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "get_buttonPool", ReturnType = typeof(DatePicker_DayButton_Pool))]
	[Calls(Type = typeof(DatePicker_DayButton_Pool), Member = "InvalidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void InvalidateDayButtonTemplate(DatePickerDayButtonType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_DateRange), Member = "ModalOverlayClicked", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ModalOverlayClicked() { }

	[CalledBy(Type = typeof(DatePicker), Member = "ShowPreviousMonth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ShowNextMonth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ShowPreviousYear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ShowNextYear", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DatePicker_Animator), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void MonthChangedUpdateDisplay() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePickerTimer), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Action), typeof(MonoBehaviour), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePickerTimer), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Action), typeof(MonoBehaviour), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void OnRectTransformDimensionsChange() { }

	[CalledBy(Type = typeof(HostSettings), Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(General), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(SerializableDate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnTextFieldValueChange(string txt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker_Animator), Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(AnimationType), typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void PlayAnimation(Animation animation, AnimationType animationType, Action onComplete = null) { }

	[CalledBy(Type = typeof(DatePicker_InputField), Member = "ShowCalendar", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExampleController), Member = "ToggleAllowMultipleDateSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	public void set_DateSelectionMode(DateSelectionMode value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IsSharedCalendar(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Ref_InputField(TMP_InputField value) { }

	[CalledBy(Type = typeof(DatePicker), Member = "OnTextFieldValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "DayButtonClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "set_FromDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "set_ToDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "DateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "ShowCalendar", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "ResetFilters", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate&), typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "UpdateInputFieldText", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_SelectedDate(SerializableDate value) { }

	[CalledBy(Type = typeof(DatePicker_InputField), Member = "ShowCalendar", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
	public void set_SelectedDates(List<SerializableDate> value) { }

	[CalledBy(Type = typeof(DatePicker_Instantiation), Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(Transform)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate&), typeof(SerializableDate)}, ReturnType = typeof(void))]
	public void set_VisibleDate(SerializableDate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public void SetConfigFromJsonString(string json) { }

	[CalledBy(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePickerTimer), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Action), typeof(MonoBehaviour), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void SetPositionAdjacentToInputFieldContainer() { }

	[CalledBy(Type = typeof(DatePicker), Member = "set_DateSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateSelectionMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePicker), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected void SetProperty(ref T currentValue, T newValue) { }

	[CalledBy(Type = typeof(DatePicker), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 18)]
	private void SetupHoldButtons() { }

	[CalledBy(Type = typeof(DatePicker), Member = "InputFieldClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "ToggleDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "<Show>b__87_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "InputFieldClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "ToggleDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "ShowCalendar", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DatePicker_Animator), Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(AnimationType), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasGroup), Member = "set_alpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "get_canvasGroup", ReturnType = typeof(CanvasGroup))]
	[Calls(Type = typeof(Transform), Member = "SetAsLastSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[Calls(Type = typeof(DatePicker), Member = "SetPositionAdjacentToInputFieldContainer", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePickerTimer), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Action), typeof(MonoBehaviour), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void Show(bool setPositionIfNecessary = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "get_VisibleDate", ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate&), typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "MonthChangedUpdateDisplay", ReturnType = typeof(void))]
	public void ShowNextMonth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "get_VisibleDate", ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate&), typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "MonthChangedUpdateDisplay", ReturnType = typeof(void))]
	public void ShowNextYear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "get_VisibleDate", ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate&), typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "MonthChangedUpdateDisplay", ReturnType = typeof(void))]
	public void ShowPreviousMonth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "get_VisibleDate", ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate&), typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "MonthChangedUpdateDisplay", ReturnType = typeof(void))]
	public void ShowPreviousYear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "SetupHoldButtons", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ToggleDisplay() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker), Member = "HideInstantly", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Update() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker_ContentLayout), Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateBorder() { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePickerDayConfig), Member = "Validate", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_Button), Member = "get_Text", ReturnType = typeof(TextMeshProUGUI))]
	[Calls(Type = typeof(TMP_Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_enableAutoSizing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePickerDayButtonConfig), Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TableCell), Member = "get_image", ReturnType = typeof(Image))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 19)]
	private void UpdateDaySection() { }

	[CalledBy(Type = typeof(DatePicker), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_ContentLayout), Member = "OnRectTransformDimensionsChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "<ShowCalendar>b__24_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExampleController), Member = "ToggleNextPreviousMonthButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExampleController), Member = "ToggleNextPreviousYearButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExampleController), Member = "ToggleWeekNumberDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExampleController), Member = "ToggleShowDatesInOtherMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExampleController), Member = "ToggleAllowMultipleDateSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	public void UpdateDisplay() { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePickerDateRangeConfig), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePickerHeaderConfig), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Header)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DatePicker), Member = "get_VisibleDate", ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(DatePicker_Header), Member = "get_HeaderText", ReturnType = typeof(TextMeshProUGUI))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void UpdateHeader() { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePicker), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "get_HasValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Single>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Single>))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Single>), typeof(System.Collections.Generic.IEnumerable`1<System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateInputField() { }

	[CalledBy(Type = typeof(DatePicker), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "DayButtonClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DatePicker), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "get_HasValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UI.Dates.SerializableDate>), typeof(System.Func`2<UI.Dates.SerializableDate, System.Boolean>)}, ReturnType = typeof(SerializableDate))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateInputFieldText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePickerWeekDaysConfig), Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_DayHeader)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWeekDayHeaders() { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(DatePicker_DayHeader), Member = "get_HeaderText", ReturnType = typeof(TextMeshProUGUI))]
	[Calls(Type = typeof(Transform), Member = "SetAsFirstSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(TableRow), Member = "AddCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableCell)}, ReturnType = typeof(TableCell))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FirstDayOfWeek", ReturnType = typeof(DayOfWeek))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(TableLayout), Member = "get_Rows", ReturnType = typeof(System.Collections.Generic.List`1<UI.Tables.TableRow>))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateWeekNumbers(ref List<DateTime>& days) { }

}

