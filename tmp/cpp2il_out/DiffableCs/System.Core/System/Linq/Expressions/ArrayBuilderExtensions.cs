namespace System.Linq.Expressions;

[Extension]
internal static class ArrayBuilderExtensions
{

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArrayBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static ReadOnlyCollection<T> ToReadOnly(ArrayBuilder<T> builder) { }

}

