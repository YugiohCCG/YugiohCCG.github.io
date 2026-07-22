namespace System.Linq.Expressions.Interpreter;

internal sealed class ArrayByRefUpdater : ByRefUpdater
{
	private readonly LocalDefinition _array; //Field offset: 0x18
	private readonly LocalDefinition _index; //Field offset: 0x28

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileArrayIndexAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ArrayByRefUpdater(LocalDefinition array, LocalDefinition index, int argumentIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(LocalVariables), Member = "UndefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public virtual void Update(InterpretedFrame frame, object value) { }

}

