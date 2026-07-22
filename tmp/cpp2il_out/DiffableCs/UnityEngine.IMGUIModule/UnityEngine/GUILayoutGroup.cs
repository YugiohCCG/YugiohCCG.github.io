namespace UnityEngine;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.CoreModule"})]
internal class GUILayoutGroup : GUILayoutEntry
{
	private static readonly GUILayoutEntry none; //Field offset: 0x0
	public List<GUILayoutEntry> entries; //Field offset: 0x48
	public bool isVertical; //Field offset: 0x50
	public bool resetCoords; //Field offset: 0x51
	public float spacing; //Field offset: 0x54
	public bool sameSize; //Field offset: 0x58
	public bool isWindow; //Field offset: 0x59
	public int windowID; //Field offset: 0x5C
	private int m_Cursor; //Field offset: 0x60
	protected int m_StretchableCountX; //Field offset: 0x64
	protected int m_StretchableCountY; //Field offset: 0x68
	protected bool m_UserSpecifiedWidth; //Field offset: 0x6C
	protected bool m_UserSpecifiedHeight; //Field offset: 0x6D
	protected float m_ChildMinWidth; //Field offset: 0x70
	protected float m_ChildMaxWidth; //Field offset: 0x74
	protected float m_ChildMinHeight; //Field offset: 0x78
	protected float m_ChildMaxHeight; //Field offset: 0x7C
	protected int m_MarginLeft; //Field offset: 0x80
	protected int m_MarginRight; //Field offset: 0x84
	protected int m_MarginTop; //Field offset: 0x88
	protected int m_MarginBottom; //Field offset: 0x8C

	public virtual int marginBottom
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public virtual int marginLeft
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public virtual int marginRight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public virtual int marginTop
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static GUILayoutGroup() { }

	[CalledBy(Type = typeof(LayoutCache), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GUILayoutGroup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayoutEntry), Member = "ApplyOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayoutEntry), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	[CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public virtual void CalcHeight() { }

	[CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcWidth", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUILayoutEntry), Member = "get_marginHorizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public virtual void CalcWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int get_marginBottom() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int get_marginLeft() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int get_marginRight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int get_marginTop() { }

	[CallerCount(Count = 0)]
	public void ResetCursor() { }

	[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUILayoutEntry), Member = "get_marginHorizontal", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public virtual void SetHorizontal(float x, float width) { }

	[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUILayoutEntry), Member = "get_marginVertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public virtual void SetVertical(float y, float height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GUILayoutEntry), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public virtual string ToString() { }

}

