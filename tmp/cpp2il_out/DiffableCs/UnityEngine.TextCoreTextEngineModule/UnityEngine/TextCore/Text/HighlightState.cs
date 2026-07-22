namespace UnityEngine.TextCore.Text;

internal struct HighlightState
{
	public Color32 color; //Field offset: 0x0
	public Offset padding; //Field offset: 0x4

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public HighlightState(Color32 color, Offset padding) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

}

