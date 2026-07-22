namespace UI.Dates;

public class DatePicker_Header : MonoBehaviour
{
	[FormerlySerializedAs("HeaderText")]
	[SerializeField]
	private Text oldHeaderText; //Field offset: 0x20
	[SerializeField]
	private TextMeshProUGUI m_HeaderText; //Field offset: 0x28
	public DatePicker_Button PreviousMonthButton; //Field offset: 0x30
	public DatePicker_Button NextMonthButton; //Field offset: 0x38
	public DatePicker_Button PreviousYearButton; //Field offset: 0x40
	public DatePicker_Button NextYearButton; //Field offset: 0x48
	public Image Background; //Field offset: 0x50
	public TableRow Row; //Field offset: 0x58
	public TableLayout TableLayout; //Field offset: 0x60

	public TextMeshProUGUI HeaderText
	{
		[CalledBy(Type = typeof(DatePicker), Member = "UpdateHeader", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePickerHeaderConfig), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Header)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DatePicker_TextMeshProUtilities), Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 239
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DatePicker_Header() { }

	[CalledBy(Type = typeof(DatePicker), Member = "UpdateHeader", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePickerHeaderConfig), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Header)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_TextMeshProUtilities), Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public TextMeshProUGUI get_HeaderText() { }

}

