namespace UI.Dates;

public class DatePickerDayButtonConfig
{
	[Tooltip("If this value is set, then the values provided here will override the values of the template. If you wish to modify the template directly, this value should be cleared.")]
	public bool OverrideTemplate; //Field offset: 0x10
	[Header("Text")]
	public Color TextColor; //Field offset: 0x14
	[Header("Background")]
	public Sprite BackgroundImage; //Field offset: 0x28
	public ColorBlock BackgroundColors; //Field offset: 0x30

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DatePickerDayButtonConfig() { }

	[CalledBy(Type = typeof(DatePicker), Member = "UpdateDaySection", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_TextMeshProUtilities), Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
	[Calls(Type = typeof(Selectable), Member = "set_colors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyConfig(DatePicker_Button button) { }

}

