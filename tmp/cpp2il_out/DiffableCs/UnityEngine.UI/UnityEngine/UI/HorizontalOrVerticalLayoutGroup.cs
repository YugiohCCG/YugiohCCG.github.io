namespace UnityEngine.UI;

[ExecuteAlways]
public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
{
	[SerializeField]
	protected float m_Spacing; //Field offset: 0x60
	[SerializeField]
	protected bool m_ChildForceExpandWidth; //Field offset: 0x64
	[SerializeField]
	protected bool m_ChildForceExpandHeight; //Field offset: 0x65
	[SerializeField]
	protected bool m_ChildControlWidth; //Field offset: 0x66
	[SerializeField]
	protected bool m_ChildControlHeight; //Field offset: 0x67
	[SerializeField]
	protected bool m_ChildScaleWidth; //Field offset: 0x68
	[SerializeField]
	protected bool m_ChildScaleHeight; //Field offset: 0x69
	[SerializeField]
	protected bool m_ReverseArrangement; //Field offset: 0x6A

	public bool childControlHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public bool childControlWidth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public bool childForceExpandHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public bool childForceExpandWidth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = "Scenes.General.HandCards", Member = "AdjustLayoutSize", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public bool childScaleHeight
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public bool childScaleWidth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public bool reverseArrangement
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public float spacing
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CalledBy(Type = "Scenes.General.HandCards", Member = "AdjustLayoutSize", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected HorizontalOrVerticalLayoutGroup() { }

	[CalledBy(Type = typeof(HorizontalLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalLayoutGroup), Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalLayoutGroup), Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LayoutUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetFlexibleSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_childControlHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_childControlWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_childForceExpandHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_childForceExpandWidth() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_childScaleHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_childScaleWidth() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_reverseArrangement() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_spacing() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetFlexibleSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	public void set_childControlHeight(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	public void set_childControlWidth(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	public void set_childForceExpandHeight(bool value) { }

	[CalledBy(Type = "Scenes.General.HandCards", Member = "AdjustLayoutSize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	public void set_childForceExpandWidth(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	public void set_childScaleHeight(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	public void set_childScaleWidth(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	public void set_reverseArrangement(bool value) { }

	[CalledBy(Type = "Scenes.General.HandCards", Member = "AdjustLayoutSize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(void))]
	public void set_spacing(float value) { }

	[CalledBy(Type = typeof(HorizontalLayoutGroup), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalLayoutGroup), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalLayoutGroup), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalLayoutGroup), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetFlexibleSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(LayoutGroup), Member = "GetStartOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

}

