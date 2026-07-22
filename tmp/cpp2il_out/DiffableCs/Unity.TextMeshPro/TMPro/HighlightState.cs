namespace TMPro;

public struct HighlightState
{
	public Color32 color; //Field offset: 0x0
	public TMP_Offset padding; //Field offset: 0x4

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public HighlightState(Color32 color, TMP_Offset padding) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool Equals(HighlightState other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

}

