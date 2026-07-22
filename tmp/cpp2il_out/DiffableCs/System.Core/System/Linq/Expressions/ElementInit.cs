namespace System.Linq.Expressions;

public sealed class ElementInit : IArgumentProvider
{
	[CompilerGenerated]
	private readonly MethodInfo <AddMethod>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<Expression> <Arguments>k__BackingField; //Field offset: 0x18

	public MethodInfo AddMethod
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override int ArgumentCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 68
	}

	public ReadOnlyCollection<Expression> Arguments
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MethodInfo get_AddMethod() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public override int get_ArgumentCount() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ReadOnlyCollection<Expression> get_Arguments() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override Expression GetArgument(int index) { }

}

