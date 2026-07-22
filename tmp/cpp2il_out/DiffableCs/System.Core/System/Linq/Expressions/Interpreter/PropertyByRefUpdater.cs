namespace System.Linq.Expressions.Interpreter;

internal sealed class PropertyByRefUpdater : ByRefUpdater
{
	private readonly Nullable<LocalDefinition> _object; //Field offset: 0x18
	private readonly PropertyInfo _property; //Field offset: 0x30

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public PropertyByRefUpdater(Nullable<LocalDefinition> obj, PropertyInfo property, int argumentIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(LocalVariables), Member = "UndefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionHelpers), Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 6)]
	public virtual void Update(InterpretedFrame frame, object value) { }

}

