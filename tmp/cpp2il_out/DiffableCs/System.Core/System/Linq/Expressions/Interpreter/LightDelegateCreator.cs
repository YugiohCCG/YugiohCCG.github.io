namespace System.Linq.Expressions.Interpreter;

internal sealed class LightDelegateCreator
{
	private readonly LambdaExpression _lambda; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Interpreter <Interpreter>k__BackingField; //Field offset: 0x18

	internal Interpreter Interpreter
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal LightDelegateCreator(Interpreter interpreter, LambdaExpression lambda) { }

	[CalledBy(Type = typeof(Expression`1), Member = "Compile", ReturnType = "TDelegate")]
	[CalledBy(Type = typeof(Expression`1), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "TDelegate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightDelegateCreator), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IStrongBox[])}, ReturnType = typeof(Delegate))]
	public Delegate CreateDelegate() { }

	[CalledBy(Type = typeof(LightDelegateCreator), Member = "CreateDelegate", ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(CreateDelegateInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightLambda), Member = "GetRunDelegateCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Func`2<System.Linq.Expressions.Interpreter.LightLambda, System.Delegate>))]
	[Calls(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal Delegate CreateDelegate(IStrongBox[] closure) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal Interpreter get_Interpreter() { }

}

