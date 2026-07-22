namespace UI.Dates;

public class DatePicker_DayHeader : MonoBehaviour
{
	[FormerlySerializedAs("HeaderText")]
	[HideInInspector]
	[SerializeField]
	private Text oldHeaderText; //Field offset: 0x20
	[SerializeField]
	private TextMeshProUGUI m_HeaderText; //Field offset: 0x28
	public TableCell Cell; //Field offset: 0x30

	public TextMeshProUGUI HeaderText
	{
		[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker), Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(List`1<DateTime>&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePickerWeekDaysConfig), Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_DayHeader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DatePicker_TextMeshProUtilities), Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
		[Calls(Type = typeof(TMP_Text), Member = "set_enableAutoSizing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 317
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DatePicker_DayHeader() { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(List`1<DateTime>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePickerWeekDaysConfig), Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_DayHeader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_TextMeshProUtilities), Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
	[Calls(Type = typeof(TMP_Text), Member = "set_enableAutoSizing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public TextMeshProUGUI get_HeaderText() { }

}

