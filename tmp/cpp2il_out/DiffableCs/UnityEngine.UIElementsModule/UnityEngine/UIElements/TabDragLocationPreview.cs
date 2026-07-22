namespace UnityEngine.UIElements;

internal class TabDragLocationPreview : VisualElement
{
	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string visualUssClassName; //Field offset: 0x8
	public static readonly string verticalUssClassName; //Field offset: 0x10
	public static readonly string horizontalUssClassName; //Field offset: 0x18
	private VisualElement m_Preview; //Field offset: 0x4A8

	internal VisualElement preview
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	private static TabDragLocationPreview() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public TabDragLocationPreview() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal VisualElement get_preview() { }

}

