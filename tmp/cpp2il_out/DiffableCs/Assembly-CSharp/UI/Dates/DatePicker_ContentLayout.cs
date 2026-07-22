namespace UI.Dates;

public class DatePicker_ContentLayout : MonoBehaviour
{
	public DatePicker DatePicker; //Field offset: 0x20
	private RectTransform m_rectTransform; //Field offset: 0x28

	protected RectTransform rectTransform
	{
		[CalledBy(Type = typeof(DatePicker_ContentLayout), Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_ContentLayout), Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 141
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DatePicker_ContentLayout() { }

	[CalledBy(Type = typeof(DatePicker_ContentLayout), Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_ContentLayout), Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	protected RectTransform get_rectTransform() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "UpdateDisplay", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnRectTransformDimensionsChanged() { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "UpdateBorder", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DatePicker_ContentLayout), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetBorderSize(RectOffset borderSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_ContentLayout), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetBorderSize(int borderSize) { }

}

