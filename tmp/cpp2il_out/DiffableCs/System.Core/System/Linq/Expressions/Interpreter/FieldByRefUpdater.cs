namespace System.Linq.Expressions.Interpreter;

internal sealed class FieldByRefUpdater : ByRefUpdater
{
	private readonly Nullable<LocalDefinition> _object; //Field offset: 0x18
	private readonly FieldInfo _field; //Field offset: 0x30

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public FieldByRefUpdater(Nullable<LocalDefinition> obj, FieldInfo field, int argumentIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(LocalVariables), Member = "UndefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Update(InterpretedFrame frame, object value) { }

}

