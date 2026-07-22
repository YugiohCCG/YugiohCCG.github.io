namespace UI.Dates;

[ExecuteInEditMode]
public class DatePicker_InputField : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SerializableDate, Boolean> <>9__29_0; //Field offset: 0x8
		public static Func<SerializableDate, Boolean> <>9__29_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <UpdateInputFieldText>b__29_0(SerializableDate s) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <UpdateInputFieldText>b__29_1(SerializableDate s) { }

	}

	[SerializeField]
	private DateSelectionMode m_DateSelectionMode; //Field offset: 0x20
	[SerializeField]
	private SerializableDate m_SelectedDate; //Field offset: 0x28
	[SerializeField]
	private List<SerializableDate> m_SelectedDates; //Field offset: 0x30
	public DatePickerInputFieldConfig InputFieldConfig; //Field offset: 0x38
	public DatePickerEventConfig EventConfig; //Field offset: 0x40
	[Header("References")]
	public DatePicker Ref_SharedDatePicker; //Field offset: 0x50
	[FormerlySerializedAs("Ref_InputField")]
	[HideInInspector]
	[SerializeField]
	private InputField Ref_OldInputField; //Field offset: 0x58
	[SerializeField]
	private TMP_InputField m_Ref_InputField; //Field offset: 0x60
	public TableLayout Ref_InputFieldContainer; //Field offset: 0x68
	public TableCell Ref_InputFieldToggleButtonCell; //Field offset: 0x70

	public DateSelectionMode DateSelectionMode
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DatePicker_InputField), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		 set { } //Length: 75
	}

	public TMP_InputField Ref_InputField
	{
		[CalledBy(Type = typeof(DatePicker_InputField), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_InputField), Member = "UpdateDisplay", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_InputField), Member = "ShowCalendar", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_InputField), Member = "UpdateInputFieldText", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DatePicker_TextMeshProUtilities), Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 167
	}

	public SerializableDate SelectedDate
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DatePicker_InputField), Member = "OnDaySelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DatePicker_InputField), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate&), typeof(SerializableDate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DatePicker_InputField), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 486
	}

	public List<SerializableDate> SelectedDates
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DatePicker_InputField), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
		 set { } //Length: 76
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public DatePicker_InputField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <ShowCalendar>b__24_0() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public DateSelectionMode get_DateSelectionMode() { }

	[CalledBy(Type = typeof(DatePicker_InputField), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "ShowCalendar", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "UpdateInputFieldText", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void HideCalendar() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_InputField), Member = "ShowCalendar", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void InputFieldClicked() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.DateTime>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	private void OnDayMouseOver(DateTime date) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker_InputField), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(DatePicker_InputField), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.DateTime>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDaySelected(DateTime date) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker_InputField), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	public void set_DateSelectionMode(DateSelectionMode value) { }

	[CalledBy(Type = typeof(DatePicker_InputField), Member = "OnDaySelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePicker_InputField), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate&), typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_InputField), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_SelectedDate(SerializableDate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker_InputField), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
	public void set_SelectedDates(List<SerializableDate> value) { }

	[CalledBy(Type = typeof(DatePicker_InputField), Member = "set_DateSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateSelectionMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePicker_InputField), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected void SetProperty(ref T currentValue, T newValue) { }

	[CalledBy(Type = typeof(DatePicker_InputField), Member = "InputFieldClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "ToggleDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DatePicker_InputField), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveAllListeners", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "set_DateSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateSelectionMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "set_SelectedDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UI.Dates.SerializableDate>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePickerTimer), Member = "AtEndOfFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(MonoBehaviour), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void ShowCalendar() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker_InputField), Member = "UpdateDisplay", ReturnType = typeof(void))]
	private void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_InputField), Member = "ShowCalendar", ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ToggleDisplay() { }

	[CalledBy(Type = typeof(DatePicker_InputField), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_InputField), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DatePicker_InputField), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_InputField), Member = "UpdateInputFieldText", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Single>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Single>))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Single>), typeof(System.Collections.Generic.IEnumerable`1<System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TableLayout), Member = "UpdateLayout", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void UpdateDisplay() { }

	[CalledBy(Type = typeof(DatePicker_InputField), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePicker_InputField), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UI.Dates.SerializableDate>), typeof(System.Func`2<UI.Dates.SerializableDate, System.Boolean>)}, ReturnType = typeof(SerializableDate))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateInputFieldText() { }

}

