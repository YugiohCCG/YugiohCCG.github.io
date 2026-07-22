namespace System.Linq.Expressions.Interpreter;

internal sealed class ParameterByRefUpdater : ByRefUpdater
{
	private readonly LocalVariable _parameter; //Field offset: 0x18

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ParameterByRefUpdater(LocalVariable parameter, int argumentIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	public virtual void Update(InterpretedFrame frame, object value) { }

}

