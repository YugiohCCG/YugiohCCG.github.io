namespace UI.Dates;

public class DatePickerButtonConfig
{
	public Sprite Image; //Field offset: 0x10
	public ColorBlock Colors; //Field offset: 0x18
	public bool PreserveAspect; //Field offset: 0x70

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DatePickerButtonConfig() { }

	[CalledBy(Type = typeof(DatePickerHeaderConfig), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Header)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DatePickerExtensions), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock), typeof(ColorBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_preserveAspect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyConfig(DatePicker_Button button) { }

}

