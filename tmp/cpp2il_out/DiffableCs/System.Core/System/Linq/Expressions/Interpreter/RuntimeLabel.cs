namespace System.Linq.Expressions.Interpreter;

[IsReadOnly]
internal struct RuntimeLabel
{
	public readonly int Index; //Field offset: 0x0
	public readonly int StackDepth; //Field offset: 0x4
	public readonly int ContinuationStackDepth; //Field offset: 0x8

	[CalledBy(Type = typeof(InstructionList), Member = "BuildRuntimeLabels", ReturnType = typeof(RuntimeLabel[]))]
	[CalledBy(Type = typeof(InstructionList), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public RuntimeLabel(int index, int continuationStackDepth, int stackDepth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

