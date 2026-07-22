namespace UnityEngine;

internal sealed class GUIScrollGroup : GUILayoutGroup
{
	public float calcMinWidth; //Field offset: 0x90
	public float calcMaxWidth; //Field offset: 0x94
	public float calcMinHeight; //Field offset: 0x98
	public float calcMaxHeight; //Field offset: 0x9C
	public float clientWidth; //Field offset: 0xA0
	public float clientHeight; //Field offset: 0xA4
	public bool allowHorizontalScroll; //Field offset: 0xA8
	public bool allowVerticalScroll; //Field offset: 0xA9
	public bool needsHorizontalScrollbar; //Field offset: 0xAA
	public bool needsVerticalScrollbar; //Field offset: 0xAB
	public GUIStyle horizontalScrollbar; //Field offset: 0xB0
	public GUIStyle verticalScrollbar; //Field offset: 0xB8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[RequiredByNativeCode]
	public GUIScrollGroup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual void CalcHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public virtual void CalcWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual void SetHorizontal(float x, float width) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public virtual void SetVertical(float y, float height) { }

}

