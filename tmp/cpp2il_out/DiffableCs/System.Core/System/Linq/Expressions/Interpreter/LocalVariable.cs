namespace System.Linq.Expressions.Interpreter;

internal sealed class LocalVariable
{
	public readonly int Index; //Field offset: 0x10
	private int _flags; //Field offset: 0x14

	public bool InClosure
	{
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public bool IsBoxed
	{
		[CalledBy(Type = typeof(LightCompiler), Member = "EnsureAvailableForClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
		[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		 set { } //Length: 25
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal LocalVariable(int index, bool closure) { }

	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_InClosure() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureAvailableForClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
	[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public bool get_IsBoxed() { }

	[CallerCount(Count = 0)]
	public void set_IsBoxed(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

