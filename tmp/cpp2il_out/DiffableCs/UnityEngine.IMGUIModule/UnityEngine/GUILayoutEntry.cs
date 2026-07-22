namespace UnityEngine;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class GUILayoutEntry
{
	internal static Rect kDummyRect; //Field offset: 0x0
	protected static int indent; //Field offset: 0x10
	public float minWidth; //Field offset: 0x10
	public float maxWidth; //Field offset: 0x14
	public float minHeight; //Field offset: 0x18
	public float maxHeight; //Field offset: 0x1C
	public Rect rect; //Field offset: 0x20
	public int stretchWidth; //Field offset: 0x30
	public int stretchHeight; //Field offset: 0x34
	public bool consideredForMargin; //Field offset: 0x38
	private GUIStyle m_Style; //Field offset: 0x40

	public override int marginBottom
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
		[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 44
	}

	public int marginHorizontal
	{
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		 get { } //Length: 64
	}

	public override int marginLeft
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
		[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 44
	}

	public override int marginRight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
		[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 44
	}

	public override int marginTop
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
		[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 44
	}

	public int marginVertical
	{
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		 get { } //Length: 64
	}

	public GUIStyle style
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 62
	}

	[CallerCount(Count = 0)]
	private static GUILayoutEntry() { }

	[CalledBy(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public override void ApplyOptions(GUILayoutOption[] options) { }

	[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	protected override void ApplyStyleSettings(GUIStyle style) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalcHeight() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalcWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public override int get_marginBottom() { }

	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	public int get_marginHorizontal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public override int get_marginLeft() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public override int get_marginRight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public override int get_marginTop() { }

	[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public int get_marginVertical() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public GUIStyle get_style() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_style(GUIStyle value) { }

	[CallerCount(Count = 0)]
	public override void SetHorizontal(float x, float width) { }

	[CallerCount(Count = 0)]
	public override void SetVertical(float y, float height) { }

	[CalledBy(Type = typeof(GUILayoutGroup), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GUIStyle), Member = "get_rawName", ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 41)]
	public virtual string ToString() { }

}

